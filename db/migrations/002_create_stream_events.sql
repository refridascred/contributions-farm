-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);
