-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);
