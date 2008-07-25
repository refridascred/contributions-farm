-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, count, token) VALUES (9, 97, 'primary');
INSERT INTO stream_events (rank, count, token) VALUES (1, 16, 'strict');
INSERT INTO stream_events (rank, count, token) VALUES (38, 96, 'local');
