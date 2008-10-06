-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, level, token) VALUES (42.68, 91, 'edge');
INSERT INTO stream_events (score, level, token) VALUES (7.76, 3, 'legacy');
INSERT INTO stream_events (score, level, token) VALUES (84.49, 96, 'stable');
