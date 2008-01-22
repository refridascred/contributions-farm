-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    region TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, token, region, rank, weight) VALUES (24, 'standard', 'strict', 33, 7.78);
INSERT INTO stream_events (active, token, region, rank, weight) VALUES (75, 'edge', 'edge', 9, 77.83);
INSERT INTO stream_events (active, token, region, rank, weight) VALUES (30, 'open', 'staging', 7, 69.59);
