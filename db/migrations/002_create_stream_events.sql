-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, count, level) VALUES ('open', 38, 61);
INSERT INTO stream_events (region, count, level) VALUES ('edge', 48, 6);
INSERT INTO stream_events (region, count, level) VALUES ('staging', 87, 76);
