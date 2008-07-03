-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, token, ratio, level, weight) VALUES (53.68, 'eu-west', 54.33, 27, 54.87);
INSERT INTO stream_events (score, token, ratio, level, weight) VALUES (34.11, 'open', 57.79, 17, 22.72);
