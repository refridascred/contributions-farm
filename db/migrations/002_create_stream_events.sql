-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (ratio, region, token) VALUES (61.3, 'edge', 'cached');
INSERT INTO stream_events (ratio, region, token) VALUES (17.31, 'blue', 'strict');
INSERT INTO stream_events (ratio, region, token) VALUES (61.24, 'strict', 'primary');
