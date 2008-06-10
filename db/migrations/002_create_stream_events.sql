-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (weight, rank, score) VALUES (79.68, 71, 2.44);
INSERT INTO stream_events (weight, rank, score) VALUES (28.58, 91, 63.91);
INSERT INTO stream_events (weight, rank, score) VALUES (52.09, 88, 90.94);
