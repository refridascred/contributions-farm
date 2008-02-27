-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, weight, token) VALUES (23, 35.79, 'edge');
INSERT INTO stream_events (level, weight, token) VALUES (0, 97.74, 'stable');
INSERT INTO stream_events (level, weight, token) VALUES (51, 67.71, 'legacy');
