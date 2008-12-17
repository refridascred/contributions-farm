-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (score, ratio, active, rank, weight) VALUES (76.76, 28.07, 9, 51, 74.05);
INSERT INTO stream_events (score, ratio, active, rank, weight) VALUES (55.81, 19.01, 40, 82, 82.54);
