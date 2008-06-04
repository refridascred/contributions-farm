-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    label TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);
