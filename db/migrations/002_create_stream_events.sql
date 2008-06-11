-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (count, ratio, level, rank) VALUES (4, 2.05, 35, 2);
INSERT INTO stream_events (count, ratio, level, rank) VALUES (12, 44.74, 92, 94);
INSERT INTO stream_events (count, ratio, level, rank) VALUES (78, 23.21, 34, 75);
