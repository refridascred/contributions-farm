-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, active, weight, ratio, score) VALUES (76, 36, 42.36, 46.86, 74.41);
INSERT INTO stream_events (level, active, weight, ratio, score) VALUES (92, 17, 37.9, 5.71, 56.6);
