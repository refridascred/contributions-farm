-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, score, state, owner, token) VALUES ('latest', 77.48, 'strict', 'primary', 'latest');
INSERT INTO stream_events (label, score, state, owner, token) VALUES ('latest', 82.97, 'latest', 'latest', 'legacy');
INSERT INTO stream_events (label, score, state, owner, token) VALUES ('primary', 51.65, 'fallback', 'blue', 'local');
