-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, score, weight) VALUES (45, 30.52, 7.61);
INSERT INTO stream_events (level, score, weight) VALUES (82, 23.3, 85.83);
INSERT INTO stream_events (level, score, weight) VALUES (89, 43.22, 59.0);
