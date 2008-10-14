-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);
