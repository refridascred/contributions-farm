-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (region, weight, ratio) VALUES ('cached', 77.14, 4.62);
INSERT INTO stream_events (region, weight, ratio) VALUES ('stable', 59.41, 59.6);
INSERT INTO stream_events (region, weight, ratio) VALUES ('green', 37.28, 71.56);
