-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, level, count) VALUES ('stable', 62, 45);
INSERT INTO stream_events (region, level, count) VALUES ('primary', 19, 98);
INSERT INTO stream_events (region, level, count) VALUES ('local', 91, 69);
