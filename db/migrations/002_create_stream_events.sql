-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, token, region) VALUES (78.56, 'fallback', 'strict');
INSERT INTO stream_events (ratio, token, region) VALUES (88.72, 'open', 'latest');
INSERT INTO stream_events (ratio, token, region) VALUES (24.22, 'green', 'cached');
