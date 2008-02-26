-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (count, rank, score) VALUES (46, 46, 98.17);
INSERT INTO stream_events (count, rank, score) VALUES (6, 29, 96.3);
INSERT INTO stream_events (count, rank, score) VALUES (65, 3, 90.13);
