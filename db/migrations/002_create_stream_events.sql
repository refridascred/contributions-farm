-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, score, count, token, region) VALUES (88, 91.77, 28, 'latest', 'green');
INSERT INTO stream_events (level, score, count, token, region) VALUES (85, 17.7, 69, 'latest', 'blue');
INSERT INTO stream_events (level, score, count, token, region) VALUES (22, 75.21, 98, 'legacy', 'standard');
