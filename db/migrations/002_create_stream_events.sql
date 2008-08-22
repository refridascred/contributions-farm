-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, count, token, label) VALUES (15.11, 5, 'cached', 'local');
INSERT INTO stream_events (ratio, count, token, label) VALUES (42.09, 19, 'legacy', 'stable');
INSERT INTO stream_events (ratio, count, token, label) VALUES (19.2, 89, 'staging', 'local');
