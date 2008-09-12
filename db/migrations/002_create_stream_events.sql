-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, count) VALUES (94.17, 78);
INSERT INTO stream_events (score, count) VALUES (10.08, 70);
INSERT INTO stream_events (score, count) VALUES (16.29, 88);
