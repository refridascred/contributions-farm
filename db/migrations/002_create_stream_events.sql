-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (weight, score, rank, label) VALUES (13.99, 12.19, 10, 'green');
