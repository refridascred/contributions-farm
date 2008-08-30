-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (count, label, score) VALUES (53, 'stable', 7.85);
INSERT INTO stream_events (count, label, score) VALUES (60, 'edge', 38.5);
INSERT INTO stream_events (count, label, score) VALUES (72, 'edge', 40.23);
