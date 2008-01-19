-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, ratio, token) VALUES (1, 49.95, 'primary');
INSERT INTO stream_events (level, ratio, token) VALUES (74, 6.64, 'eu-west');
