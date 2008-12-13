-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (weight, rank, token, owner) VALUES (96.92, 71, 'latest', 'strict');
