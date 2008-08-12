-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, ratio, score) VALUES ('cached', 60.17, 83.97);
INSERT INTO stream_events (region, ratio, score) VALUES ('green', 50.74, 53.02);
