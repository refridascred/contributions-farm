-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (weight, count, level, score) VALUES (58.27, 72, 42, 17.2);
INSERT INTO stream_events (weight, count, level, score) VALUES (82.61, 87, 98, 54.94);
INSERT INTO stream_events (weight, count, level, score) VALUES (57.62, 15, 79, 76.02);
