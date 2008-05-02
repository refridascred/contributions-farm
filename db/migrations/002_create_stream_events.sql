-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, rank, count, weight) VALUES (16.73, 54, 35, 66.06);
INSERT INTO stream_events (ratio, rank, count, weight) VALUES (65.2, 6, 47, 28.88);
INSERT INTO stream_events (ratio, rank, count, weight) VALUES (97.4, 5, 65, 48.3);
