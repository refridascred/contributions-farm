-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, state, level, owner) VALUES ('eu-west', 'staging', 4, 'edge');
INSERT INTO stream_events (token, state, level, owner) VALUES ('standard', 'strict', 39, 'standard');
