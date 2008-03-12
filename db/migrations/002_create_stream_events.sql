-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);
