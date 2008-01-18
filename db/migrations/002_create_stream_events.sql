-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, token, count, ratio, owner) VALUES (51.84, 'eu-west', 21, 76.48, 'stable');
INSERT INTO stream_events (score, token, count, ratio, owner) VALUES (19.37, 'fallback', 54, 29.35, 'edge');
