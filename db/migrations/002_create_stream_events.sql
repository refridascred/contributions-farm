-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (score, weight, token) VALUES (84.57, 81.45, 'eu-west');
INSERT INTO stream_events (score, weight, token) VALUES (13.09, 37.96, 'latest');
