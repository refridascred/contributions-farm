-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, ratio, count, active) VALUES (69, 92.87, 5, 68);
INSERT INTO stream_events (rank, ratio, count, active) VALUES (28, 86.83, 31, 76);
INSERT INTO stream_events (rank, ratio, count, active) VALUES (56, 22.96, 58, 49);
