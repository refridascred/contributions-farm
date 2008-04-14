-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, token, region, level) VALUES (55.19, 'legacy', 'green', 35);
INSERT INTO stream_events (score, token, region, level) VALUES (79.12, 'local', 'staging', 98);
INSERT INTO stream_events (score, token, region, level) VALUES (81.27, 'latest', 'local', 67);
