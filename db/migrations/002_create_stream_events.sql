-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (active, token, ratio, region) VALUES (36, 'green', 82.2, 'local');
INSERT INTO stream_events (active, token, ratio, region) VALUES (38, 'fallback', 44.49, 'fallback');
