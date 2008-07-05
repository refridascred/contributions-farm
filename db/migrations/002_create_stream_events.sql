-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, region, score, weight, active) VALUES ('eu-west', 'fallback', 15.26, 87.56, 84);
INSERT INTO stream_events (token, region, score, weight, active) VALUES ('edge', 'stable', 21.26, 14.88, 56);
INSERT INTO stream_events (token, region, score, weight, active) VALUES ('green', 'latest', 52.97, 10.37, 20);
