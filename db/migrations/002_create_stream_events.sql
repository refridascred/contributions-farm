-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, active, region, owner, token) VALUES (69.43, 93, 'green', 'primary', 'cached');
INSERT INTO stream_events (score, active, region, owner, token) VALUES (36.55, 15, 'cached', 'edge', 'legacy');
