-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (ratio, active, weight, region) VALUES (50.49, 76, 22.61, 'primary');
INSERT INTO stream_events (ratio, active, weight, region) VALUES (63.1, 92, 97.61, 'legacy');
