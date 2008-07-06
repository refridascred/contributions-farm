-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (token, score, owner, active) VALUES ('edge', 62.54, 'standard', 35);
INSERT INTO stream_events (token, score, owner, active) VALUES ('legacy', 54.99, 'edge', 45);
INSERT INTO stream_events (token, score, owner, active) VALUES ('legacy', 70.98, 'local', 80);
