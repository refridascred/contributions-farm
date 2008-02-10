-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (region, label, weight, rank) VALUES ('blue', 'latest', 86.76, 51);
INSERT INTO stream_events (region, label, weight, rank) VALUES ('edge', 'local', 54.31, 86);
