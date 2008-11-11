-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, token, score, active, label) VALUES ('green', 'local', 68.63, 32, 'edge');
INSERT INTO stream_events (owner, token, score, active, label) VALUES ('local', 'legacy', 84.47, 44, 'legacy');
