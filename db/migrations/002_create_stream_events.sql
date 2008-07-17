-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (ratio, weight, state, region) VALUES (75.55, 12.39, 'green', 'cached');
INSERT INTO stream_events (ratio, weight, state, region) VALUES (77.19, 56.63, 'fallback', 'eu-west');
INSERT INTO stream_events (ratio, weight, state, region) VALUES (3.36, 66.02, 'latest', 'primary');
