-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (score, owner, active, token) VALUES (64.17, 'strict', 18, 'fallback');
INSERT INTO stream_events (score, owner, active, token) VALUES (98.41, 'local', 58, 'edge');
INSERT INTO stream_events (score, owner, active, token) VALUES (57.75, 'staging', 58, 'latest');
