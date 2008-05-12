-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (active, token, count, ratio, label) VALUES (65, 'fallback', 88, 21.99, 'cached');
INSERT INTO stream_events (active, token, count, ratio, label) VALUES (11, 'staging', 46, 35.2, 'latest');
