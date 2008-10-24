-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, rank, owner) VALUES (51, 43, 'legacy');
INSERT INTO stream_events (active, rank, owner) VALUES (38, 94, 'standard');
INSERT INTO stream_events (active, rank, owner) VALUES (94, 11, 'local');
