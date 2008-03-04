-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (score, label, ratio, count, token) VALUES (53.8, 'legacy', 94.09, 56, 'primary');
INSERT INTO stream_events (score, label, ratio, count, token) VALUES (47.06, 'open', 31.57, 21, 'fallback');
