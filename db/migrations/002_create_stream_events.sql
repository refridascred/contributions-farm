-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, weight, rank) VALUES (21, 33.07, 83);
INSERT INTO stream_events (active, weight, rank) VALUES (57, 66.43, 9);
INSERT INTO stream_events (active, weight, rank) VALUES (42, 82.04, 89);
