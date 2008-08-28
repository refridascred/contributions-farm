-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, score, count, active) VALUES (92, 42.07, 17, 18);
INSERT INTO stream_events (rank, score, count, active) VALUES (77, 19.67, 49, 32);
INSERT INTO stream_events (rank, score, count, active) VALUES (98, 5.81, 25, 51);
