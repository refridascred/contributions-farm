-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, owner, score, active, level) VALUES (94.92, 'fallback', 8.97, 79, 96);
INSERT INTO stream_events (ratio, owner, score, active, level) VALUES (37.09, 'edge', 54.33, 88, 55);
