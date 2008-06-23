-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (region, weight, ratio, token, score) VALUES ('cached', 2.33, 78.6, 'stable', 97.58);
INSERT INTO stream_events (region, weight, ratio, token, score) VALUES ('open', 73.93, 50.25, 'latest', 94.86);
