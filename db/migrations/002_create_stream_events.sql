-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, rank, score, weight) VALUES (79, 88, 71.64, 15.2);
INSERT INTO stream_events (level, rank, score, weight) VALUES (32, 61, 60.28, 52.46);
INSERT INTO stream_events (level, rank, score, weight) VALUES (13, 98, 78.1, 31.55);
