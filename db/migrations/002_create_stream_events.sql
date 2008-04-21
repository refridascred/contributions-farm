-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, level, count, region, score) VALUES ('strict', 4, 32, 'edge', 14.29);
INSERT INTO stream_events (token, level, count, region, score) VALUES ('latest', 61, 74, 'staging', 58.21);
INSERT INTO stream_events (token, level, count, region, score) VALUES ('local', 86, 66, 'strict', 51.86);
