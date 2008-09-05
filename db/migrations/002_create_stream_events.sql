-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, ratio, weight, score) VALUES ('fallback', 27.19, 94.97, 38.47);
INSERT INTO stream_events (owner, ratio, weight, score) VALUES ('staging', 38.13, 60.76, 52.45);
INSERT INTO stream_events (owner, ratio, weight, score) VALUES ('green', 91.32, 3.34, 54.76);
