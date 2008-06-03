-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, state, label, region, count) VALUES ('staging', 'standard', 'fallback', 'cached', 67);
