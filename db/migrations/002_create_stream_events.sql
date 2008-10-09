-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, score, rank) VALUES (49, 33.41, 87);
INSERT INTO stream_events (level, score, rank) VALUES (66, 21.21, 30);
INSERT INTO stream_events (level, score, rank) VALUES (10, 16.36, 37);
