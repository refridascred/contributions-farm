-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (weight, rank, score, ratio) VALUES (95.86, 29, 49.93, 45.35);
INSERT INTO stream_events (weight, rank, score, ratio) VALUES (45.82, 95, 16.27, 33.89);
