-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (level, label, state, token) VALUES (41, 'cached', 'latest', 'edge');
INSERT INTO stream_events (level, label, state, token) VALUES (84, 'strict', 'primary', 'legacy');
INSERT INTO stream_events (level, label, state, token) VALUES (27, 'legacy', 'cached', 'eu-west');
