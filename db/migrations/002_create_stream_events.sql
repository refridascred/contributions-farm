-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (ratio, token, weight, score) VALUES (94.33, 'green', 91.47, 87.02);
INSERT INTO stream_events (ratio, token, weight, score) VALUES (93.81, 'standard', 56.63, 10.95);
INSERT INTO stream_events (ratio, token, weight, score) VALUES (63.58, 'eu-west', 46.89, 48.57);
