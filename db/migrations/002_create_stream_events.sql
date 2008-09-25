-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, ratio, score, count, label) VALUES (36.95, 3.51, 84.95, 39, 'cached');
INSERT INTO stream_events (weight, ratio, score, count, label) VALUES (94.54, 71.07, 27.27, 46, 'primary');
INSERT INTO stream_events (weight, ratio, score, count, label) VALUES (86.78, 82.96, 75.74, 98, 'primary');
