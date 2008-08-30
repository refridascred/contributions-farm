-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, score, token, count, level) VALUES ('primary', 93.52, 'strict', 74, 2);
INSERT INTO stream_events (region, score, token, count, level) VALUES ('eu-west', 14.35, 'blue', 89, 14);
INSERT INTO stream_events (region, score, token, count, level) VALUES ('stable', 80.37, 'strict', 14, 61);
