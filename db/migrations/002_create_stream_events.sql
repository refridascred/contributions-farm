-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (token, active, score, level, weight) VALUES ('local', 87, 76.91, 33, 17.8);
INSERT INTO stream_events (token, active, score, level, weight) VALUES ('green', 48, 30.86, 13, 63.14);
