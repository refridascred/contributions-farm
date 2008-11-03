-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, token, region) VALUES (93.58, 'green', 'green');
INSERT INTO stream_events (ratio, token, region) VALUES (0.78, 'standard', 'cached');
