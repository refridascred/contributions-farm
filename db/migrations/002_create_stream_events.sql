-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    weight REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (rank, region, weight, token, label) VALUES (88, 'stable', 9.9, 'blue', 'staging');
INSERT INTO stream_events (rank, region, weight, token, label) VALUES (21, 'fallback', 80.07, 'standard', 'eu-west');
INSERT INTO stream_events (rank, region, weight, token, label) VALUES (52, 'green', 20.17, 'edge', 'local');
