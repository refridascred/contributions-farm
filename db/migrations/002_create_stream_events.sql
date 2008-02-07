-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, score, level) VALUES (64.33, 81.13, 19);
INSERT INTO stream_events (ratio, score, level) VALUES (76.07, 57.14, 41);
INSERT INTO stream_events (ratio, score, level) VALUES (14.3, 14.69, 51);
