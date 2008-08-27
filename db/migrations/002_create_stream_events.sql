-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (level, region, weight) VALUES (8, 'standard', 79.31);
INSERT INTO stream_events (level, region, weight) VALUES (11, 'eu-west', 85.23);
