-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (score, owner, token, state, active) VALUES (25.52, 'edge', 'stable', 'latest', 65);
INSERT INTO stream_events (score, owner, token, state, active) VALUES (61.63, 'legacy', 'stable', 'edge', 93);
