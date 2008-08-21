-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (region, weight, token) VALUES ('staging', 40.52, 'eu-west');
INSERT INTO stream_events (region, weight, token) VALUES ('open', 79.09, 'blue');
