-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (weight, level, rank, score) VALUES (96.14, 28, 9, 86.71);
INSERT INTO stream_events (weight, level, rank, score) VALUES (48.58, 6, 0, 48.97);
INSERT INTO stream_events (weight, level, rank, score) VALUES (81.16, 4, 15, 27.77);
