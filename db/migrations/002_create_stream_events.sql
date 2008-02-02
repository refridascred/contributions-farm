-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, ratio, level, weight) VALUES (85.66, 52.31, 70, 98.65);
INSERT INTO stream_events (score, ratio, level, weight) VALUES (86.25, 46.54, 96, 22.1);
INSERT INTO stream_events (score, ratio, level, weight) VALUES (17.56, 15.46, 14, 49.54);
