-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, score, level) VALUES (55.42, 64.3, 7);
INSERT INTO stream_events (ratio, score, level) VALUES (54.16, 61.36, 14);
INSERT INTO stream_events (ratio, score, level) VALUES (49.47, 0.07, 8);
