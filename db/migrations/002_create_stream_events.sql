-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, score, level, ratio, weight) VALUES (22, 68.44, 50, 61.24, 23.58);
INSERT INTO stream_events (rank, score, level, ratio, weight) VALUES (86, 52.3, 83, 50.19, 23.99);
