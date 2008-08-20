-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, ratio, level) VALUES ('edge', 77.25, 97);
INSERT INTO stream_events (token, ratio, level) VALUES ('green', 39.04, 11);
