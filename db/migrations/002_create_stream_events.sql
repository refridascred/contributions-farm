-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (region, ratio, weight) VALUES ('stable', 37.64, 6.05);
INSERT INTO stream_events (region, ratio, weight) VALUES ('strict', 27.69, 33.04);
INSERT INTO stream_events (region, ratio, weight) VALUES ('primary', 22.5, 17.54);
