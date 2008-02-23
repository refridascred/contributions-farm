-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, ratio, level) VALUES (49.04, 43.61, 72);
INSERT INTO stream_events (score, ratio, level) VALUES (29.43, 96.8, 63);
