-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (score, label, level, token) VALUES (12.99, 'staging', 49, 'open');
INSERT INTO stream_events (score, label, level, token) VALUES (18.33, 'fallback', 37, 'latest');
INSERT INTO stream_events (score, label, level, token) VALUES (66.2, 'cached', 9, 'green');
