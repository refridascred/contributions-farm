-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, weight, count, rank) VALUES (86, 2.49, 62, 5);
INSERT INTO stream_events (level, weight, count, rank) VALUES (12, 77.63, 29, 61);
INSERT INTO stream_events (level, weight, count, rank) VALUES (79, 62.51, 22, 99);
