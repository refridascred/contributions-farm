-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, token, ratio, level) VALUES (43.91, 'stable', 61.47, 75);
INSERT INTO stream_events (weight, token, ratio, level) VALUES (86.55, 'standard', 20.73, 5);
INSERT INTO stream_events (weight, token, ratio, level) VALUES (68.99, 'stable', 19.33, 79);
