-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, weight, region) VALUES ('staging', 75.5, 'green');
INSERT INTO stream_events (label, weight, region) VALUES ('green', 31.78, 'green');
