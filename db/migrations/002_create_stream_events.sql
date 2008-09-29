-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (score, weight, label) VALUES (47.71, 50.82, 'standard');
INSERT INTO stream_events (score, weight, label) VALUES (56.02, 16.35, 'edge');
INSERT INTO stream_events (score, weight, label) VALUES (73.9, 24.91, 'latest');
