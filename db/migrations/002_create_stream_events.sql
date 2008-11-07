-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (ratio, region, active, owner, token) VALUES (96.35, 'fallback', 87, 'latest', 'strict');
INSERT INTO stream_events (ratio, region, active, owner, token) VALUES (3.7, 'legacy', 33, 'open', 'stable');
