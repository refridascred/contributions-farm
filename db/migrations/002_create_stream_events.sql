-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, state, owner) VALUES ('blue', 'legacy', 'primary');
INSERT INTO stream_events (token, state, owner) VALUES ('strict', 'primary', 'local');
INSERT INTO stream_events (token, state, owner) VALUES ('cached', 'standard', 'stable');
