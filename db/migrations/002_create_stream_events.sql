-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (level, score, ratio, count, weight) VALUES (73, 21.53, 52.99, 16, 64.61);
INSERT INTO stream_events (level, score, ratio, count, weight) VALUES (26, 57.64, 16.2, 38, 63.24);
