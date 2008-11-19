-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, token, level, weight) VALUES (59.0, 'primary', 2, 60.33);
INSERT INTO stream_events (score, token, level, weight) VALUES (0.89, 'primary', 38, 45.11);
