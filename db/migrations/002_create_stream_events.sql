-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, ratio, level, count) VALUES (78, 69.89, 23, 66);
INSERT INTO stream_events (rank, ratio, level, count) VALUES (34, 39.78, 66, 40);
INSERT INTO stream_events (rank, ratio, level, count) VALUES (85, 24.58, 84, 42);
