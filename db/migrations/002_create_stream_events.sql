-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (ratio, count, owner, level, score) VALUES (22.3, 3, 'edge', 90, 41.5);
INSERT INTO stream_events (ratio, count, owner, level, score) VALUES (8.47, 44, 'eu-west', 43, 28.38);
