-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (score, weight, region) VALUES (12.99, 76.5, 'green');
INSERT INTO stream_events (score, weight, region) VALUES (68.75, 18.72, 'blue');
INSERT INTO stream_events (score, weight, region) VALUES (57.84, 82.93, 'standard');
