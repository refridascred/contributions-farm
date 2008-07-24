-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, score, ratio, level) VALUES (60, 2.11, 76.24, 99);
INSERT INTO stream_events (count, score, ratio, level) VALUES (89, 97.89, 71.71, 94);
INSERT INTO stream_events (count, score, ratio, level) VALUES (6, 26.56, 16.07, 37);
