-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (level, token, weight, ratio) VALUES (65, 'edge', 85.29, 51.81);
INSERT INTO stream_events (level, token, weight, ratio) VALUES (21, 'edge', 97.39, 77.28);
