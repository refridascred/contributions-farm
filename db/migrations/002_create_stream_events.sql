-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, state, token) VALUES ('strict', 'blue', 'legacy');
INSERT INTO stream_events (label, state, token) VALUES ('legacy', 'staging', 'strict');
