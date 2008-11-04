-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (token, ratio, score, weight, active) VALUES ('edge', 36.58, 90.88, 34.71, 16);
INSERT INTO stream_events (token, ratio, score, weight, active) VALUES ('standard', 81.9, 14.65, 26.1, 96);
INSERT INTO stream_events (token, ratio, score, weight, active) VALUES ('cached', 33.32, 35.83, 72.07, 50);
