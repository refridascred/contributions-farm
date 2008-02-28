-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    level INTEGER,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, ratio, level, rank, weight) VALUES ('local', 92.32, 37, 64, 79.78);
INSERT INTO stream_events (token, ratio, level, rank, weight) VALUES ('local', 10.85, 77, 41, 58.02);
