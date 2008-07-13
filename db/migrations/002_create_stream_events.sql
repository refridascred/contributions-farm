-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, score, rank, level, weight) VALUES (13.65, 5.41, 80, 29, 26.72);
INSERT INTO stream_events (ratio, score, rank, level, weight) VALUES (59.24, 60.68, 24, 40, 25.05);
