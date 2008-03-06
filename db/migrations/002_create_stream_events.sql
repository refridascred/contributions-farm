-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, score) VALUES (49, 93.38);
INSERT INTO stream_events (rank, score) VALUES (9, 47.68);
INSERT INTO stream_events (rank, score) VALUES (33, 44.32);
