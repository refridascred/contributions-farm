-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, score, ratio, level) VALUES (52.39, 81.04, 40.51, 59);
INSERT INTO stream_events (weight, score, ratio, level) VALUES (37.53, 32.72, 31.7, 65);
