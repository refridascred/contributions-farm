-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);
