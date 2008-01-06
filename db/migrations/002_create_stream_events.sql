-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, ratio, region, token) VALUES (53, 19.89, 'blue', 'fallback');
INSERT INTO stream_events (active, ratio, region, token) VALUES (73, 1.61, 'staging', 'eu-west');
