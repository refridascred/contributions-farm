-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (owner, score, active, region, token) VALUES ('staging', 98.15, 63, 'fallback', 'edge');
INSERT INTO stream_events (owner, score, active, region, token) VALUES ('primary', 74.22, 68, 'local', 'local');
