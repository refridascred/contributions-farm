-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, ratio, token) VALUES (98.45, 63.49, 'open');
INSERT INTO stream_events (weight, ratio, token) VALUES (60.33, 51.11, 'eu-west');
