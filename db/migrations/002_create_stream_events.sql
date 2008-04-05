-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (rank, weight, ratio, owner) VALUES (41, 53.31, 42.29, 'strict');
INSERT INTO stream_events (rank, weight, ratio, owner) VALUES (14, 14.93, 50.75, 'local');
