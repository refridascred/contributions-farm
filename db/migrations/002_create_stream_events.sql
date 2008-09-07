-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (owner, token, level, state, active) VALUES ('stable', 'primary', 50, 'eu-west', 76);
INSERT INTO stream_events (owner, token, level, state, active) VALUES ('legacy', 'edge', 20, 'legacy', 0);
INSERT INTO stream_events (owner, token, level, state, active) VALUES ('local', 'stable', 59, 'fallback', 3);
