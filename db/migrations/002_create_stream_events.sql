-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, ratio, region, state) VALUES (37.79, 39.54, 'staging', 'staging');
INSERT INTO stream_events (weight, ratio, region, state) VALUES (43.31, 83.71, 'latest', 'latest');
INSERT INTO stream_events (weight, ratio, region, state) VALUES (77.42, 63.93, 'staging', 'latest');
