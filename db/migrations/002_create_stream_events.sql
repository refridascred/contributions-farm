-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, label, state, owner) VALUES ('fallback', 'green', 'green', 'latest');
INSERT INTO stream_events (token, label, state, owner) VALUES ('green', 'legacy', 'stable', 'cached');
INSERT INTO stream_events (token, label, state, owner) VALUES ('open', 'fallback', 'standard', 'stable');
