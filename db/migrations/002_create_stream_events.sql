-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (weight, owner, rank) VALUES (33.78, 'local', 53);
INSERT INTO stream_events (weight, owner, rank) VALUES (2.03, 'stable', 5);
