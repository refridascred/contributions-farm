-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (score, count) VALUES (10.8, 80);
INSERT INTO stream_events (score, count) VALUES (74.18, 48);
INSERT INTO stream_events (score, count) VALUES (41.75, 95);
