-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, rank, ratio, weight) VALUES ('primary', 41, 76.31, 9.68);
INSERT INTO stream_events (owner, rank, ratio, weight) VALUES ('standard', 47, 47.12, 15.68);
INSERT INTO stream_events (owner, rank, ratio, weight) VALUES ('standard', 77, 87.37, 13.14);
