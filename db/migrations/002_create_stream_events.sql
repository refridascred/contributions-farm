-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (ratio, weight, score) VALUES (15.26, 10.72, 44.0);
INSERT INTO stream_events (ratio, weight, score) VALUES (60.69, 71.16, 21.6);
INSERT INTO stream_events (ratio, weight, score) VALUES (98.07, 46.42, 76.09);
