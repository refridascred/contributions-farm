-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, weight, ratio) VALUES (29.96, 68.44, 12.63);
INSERT INTO stream_events (score, weight, ratio) VALUES (28.24, 1.48, 53.22);
INSERT INTO stream_events (score, weight, ratio) VALUES (85.03, 96.78, 10.22);
