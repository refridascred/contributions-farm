-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);
