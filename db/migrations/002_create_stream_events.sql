-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, score, rank) VALUES (15, 42.66, 76);
INSERT INTO stream_events (active, score, rank) VALUES (33, 3.44, 75);
INSERT INTO stream_events (active, score, rank) VALUES (31, 73.83, 92);
