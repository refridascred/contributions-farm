-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, weight, active, rank) VALUES ('eu-west', 23.61, 32, 50);
INSERT INTO stream_events (owner, weight, active, rank) VALUES ('stable', 31.83, 95, 93);
