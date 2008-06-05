-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (score, level, rank) VALUES (51.37, 65, 94);
INSERT INTO stream_events (score, level, rank) VALUES (46.24, 82, 13);
INSERT INTO stream_events (score, level, rank) VALUES (47.77, 23, 94);
