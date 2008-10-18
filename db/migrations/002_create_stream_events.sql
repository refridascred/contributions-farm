-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, ratio, weight) VALUES ('standard', 69.63, 28.04);
INSERT INTO stream_events (region, ratio, weight) VALUES ('green', 89.89, 49.73);
INSERT INTO stream_events (region, ratio, weight) VALUES ('legacy', 54.47, 18.54);
