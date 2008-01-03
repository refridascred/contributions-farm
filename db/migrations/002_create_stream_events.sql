-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, level, score) VALUES (42.89, 30, 50.41);
INSERT INTO stream_events (ratio, level, score) VALUES (75.36, 88, 33.49);
INSERT INTO stream_events (ratio, level, score) VALUES (69.58, 92, 33.3);
