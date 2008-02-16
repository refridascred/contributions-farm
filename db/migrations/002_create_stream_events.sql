-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, ratio, count, rank) VALUES ('open', 37.95, 62, 21);
INSERT INTO stream_events (owner, ratio, count, rank) VALUES ('edge', 3.34, 12, 28);
INSERT INTO stream_events (owner, ratio, count, rank) VALUES ('open', 40.0, 98, 49);
