-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);
