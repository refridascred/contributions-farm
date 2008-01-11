-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (region, count, ratio, weight, rank) VALUES ('cached', 33, 4.93, 35.11, 44);
INSERT INTO stream_events (region, count, ratio, weight, rank) VALUES ('edge', 70, 17.54, 14.59, 96);
