-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, owner, rank) VALUES (71.09, 'standard', 18);
INSERT INTO stream_events (ratio, owner, rank) VALUES (94.36, 'stable', 83);
INSERT INTO stream_events (ratio, owner, rank) VALUES (4.6, 'standard', 16);
