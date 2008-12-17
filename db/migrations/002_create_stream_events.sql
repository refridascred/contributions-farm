-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (score, rank, token, weight) VALUES (72.81, 92, 'cached', 18.09);
INSERT INTO stream_events (score, rank, token, weight) VALUES (20.13, 93, 'cached', 97.23);
INSERT INTO stream_events (score, rank, token, weight) VALUES (8.14, 41, 'strict', 40.59);
