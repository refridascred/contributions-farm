-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, weight, score) VALUES (1, 90.76, 92.62);
INSERT INTO stream_events (rank, weight, score) VALUES (29, 83.75, 26.86);
INSERT INTO stream_events (rank, weight, score) VALUES (52, 5.14, 4.1);
