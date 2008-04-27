-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (state, weight, ratio, score, region) VALUES ('primary', 92.2, 40.51, 5.81, 'blue');
