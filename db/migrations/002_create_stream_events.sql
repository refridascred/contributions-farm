-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, rank, ratio, owner) VALUES (13.73, 69, 6.85, 'edge');
INSERT INTO stream_events (weight, rank, ratio, owner) VALUES (85.96, 53, 36.6, 'cached');
INSERT INTO stream_events (weight, rank, ratio, owner) VALUES (74.96, 35, 58.92, 'strict');
