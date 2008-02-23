-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, token, state, owner) VALUES ('strict', 'standard', 'green', 'cached');
INSERT INTO stream_events (label, token, state, owner) VALUES ('eu-west', 'cached', 'fallback', 'local');
INSERT INTO stream_events (label, token, state, owner) VALUES ('edge', 'staging', 'green', 'edge');
