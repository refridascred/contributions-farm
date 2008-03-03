-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (ratio, region, token, label) VALUES (40.63, 'fallback', 'fallback', 'strict');
INSERT INTO stream_events (ratio, region, token, label) VALUES (89.52, 'legacy', 'standard', 'primary');
