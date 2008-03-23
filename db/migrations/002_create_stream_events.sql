-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, weight, level, label) VALUES (0.53, 67.43, 97, 'stable');
INSERT INTO stream_events (ratio, weight, level, label) VALUES (4.99, 36.65, 96, 'latest');
