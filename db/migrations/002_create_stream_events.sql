-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (score, owner, active, weight, rank) VALUES (56.93, 'legacy', 92, 40.16, 7);
INSERT INTO stream_events (score, owner, active, weight, rank) VALUES (24.57, 'latest', 42, 74.8, 87);
INSERT INTO stream_events (score, owner, active, weight, rank) VALUES (25.04, 'legacy', 58, 89.37, 84);
