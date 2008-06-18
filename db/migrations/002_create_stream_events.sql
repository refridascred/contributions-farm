-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (ratio, level, token, weight) VALUES (95.56, 30, 'staging', 29.71);
INSERT INTO stream_events (ratio, level, token, weight) VALUES (51.71, 13, 'edge', 67.58);
INSERT INTO stream_events (ratio, level, token, weight) VALUES (84.62, 99, 'primary', 51.84);
