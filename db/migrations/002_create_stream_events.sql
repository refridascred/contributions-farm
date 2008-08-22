-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (score, count, rank) VALUES (94.38, 11, 24);
INSERT INTO stream_events (score, count, rank) VALUES (13.04, 18, 43);
INSERT INTO stream_events (score, count, rank) VALUES (33.61, 95, 84);
