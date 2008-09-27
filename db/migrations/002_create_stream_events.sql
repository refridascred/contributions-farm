-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, ratio, token) VALUES (87, 72.42, 'local');
INSERT INTO stream_events (active, ratio, token) VALUES (98, 62.12, 'edge');
INSERT INTO stream_events (active, ratio, token) VALUES (74, 18.13, 'cached');
