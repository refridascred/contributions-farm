-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    rank INTEGER,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, weight, rank, level, score) VALUES (29.52, 56.42, 86, 16, 48.61);
INSERT INTO stream_events (ratio, weight, rank, level, score) VALUES (88.39, 78.51, 79, 72, 21.0);
INSERT INTO stream_events (ratio, weight, rank, level, score) VALUES (85.14, 10.19, 14, 61, 96.98);
