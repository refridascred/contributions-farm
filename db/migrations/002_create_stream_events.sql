-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);
