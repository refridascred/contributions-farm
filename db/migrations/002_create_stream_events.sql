-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, token, region) VALUES (43.74, 'stable', 'local');
INSERT INTO stream_events (weight, token, region) VALUES (3.92, 'fallback', 'legacy');
