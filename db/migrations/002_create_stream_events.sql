-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);
