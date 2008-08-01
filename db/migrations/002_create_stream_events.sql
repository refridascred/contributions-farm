-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, count) VALUES ('stable', 56);
INSERT INTO stream_events (region, count) VALUES ('stable', 18);
INSERT INTO stream_events (region, count) VALUES ('eu-west', 50);
