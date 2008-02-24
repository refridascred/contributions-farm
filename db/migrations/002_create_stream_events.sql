-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, score, count) VALUES (27, 85.52, 71);
INSERT INTO stream_events (rank, score, count) VALUES (55, 43.16, 34);
INSERT INTO stream_events (rank, score, count) VALUES (41, 70.14, 78);
