-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, state, owner) VALUES ('strict', 'strict', 'stable');
INSERT INTO stream_events (token, state, owner) VALUES ('edge', 'blue', 'cached');
INSERT INTO stream_events (token, state, owner) VALUES ('standard', 'staging', 'local');
