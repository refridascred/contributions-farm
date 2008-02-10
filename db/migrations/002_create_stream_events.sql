-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, weight, rank, active) VALUES (32.85, 94.81, 71, 58);
INSERT INTO stream_events (ratio, weight, rank, active) VALUES (87.6, 2.71, 91, 36);
INSERT INTO stream_events (ratio, weight, rank, active) VALUES (22.31, 95.88, 10, 91);
