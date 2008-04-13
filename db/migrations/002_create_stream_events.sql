-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (owner, active, score, state, token) VALUES ('cached', 73, 59.83, 'staging', 'stable');
INSERT INTO stream_events (owner, active, score, state, token) VALUES ('latest', 92, 10.16, 'eu-west', 'open');
