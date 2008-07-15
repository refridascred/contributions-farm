-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, ratio, active, score) VALUES (42.37, 46.69, 54, 42.91);
INSERT INTO stream_events (weight, ratio, active, score) VALUES (5.42, 2.25, 70, 57.04);
INSERT INTO stream_events (weight, ratio, active, score) VALUES (16.1, 32.63, 48, 60.34);
