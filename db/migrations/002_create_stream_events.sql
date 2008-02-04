-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, count) VALUES ('eu-west', 61);
INSERT INTO stream_events (region, count) VALUES ('eu-west', 66);
INSERT INTO stream_events (region, count) VALUES ('staging', 68);
