-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, rank, count, ratio) VALUES (48.44, 28, 35, 55.85);
INSERT INTO stream_events (weight, rank, count, ratio) VALUES (56.16, 81, 29, 28.92);
INSERT INTO stream_events (weight, rank, count, ratio) VALUES (46.13, 83, 52, 72.63);
