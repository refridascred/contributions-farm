-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, score, active, label, region) VALUES ('green', 40.36, 88, 'eu-west', 'green');
INSERT INTO stream_events (token, score, active, label, region) VALUES ('fallback', 47.03, 23, 'edge', 'eu-west');
