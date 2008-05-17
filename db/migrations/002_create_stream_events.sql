-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, token, weight) VALUES (99, 'blue', 27.33);
INSERT INTO stream_events (level, token, weight) VALUES (22, 'stable', 82.21);
INSERT INTO stream_events (level, token, weight) VALUES (21, 'stable', 39.41);
