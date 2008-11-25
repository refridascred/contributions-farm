-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (level, count, token, region, score) VALUES (12, 39, 'eu-west', 'local', 14.11);
INSERT INTO stream_events (level, count, token, region, score) VALUES (48, 72, 'edge', 'strict', 83.46);
INSERT INTO stream_events (level, count, token, region, score) VALUES (1, 35, 'local', 'staging', 77.17);
