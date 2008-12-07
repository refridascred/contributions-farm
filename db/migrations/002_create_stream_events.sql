-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (score, count, active, region) VALUES (56.19, 49, 90, 'open');
INSERT INTO stream_events (score, count, active, region) VALUES (81.29, 25, 10, 'fallback');
INSERT INTO stream_events (score, count, active, region) VALUES (93.95, 44, 10, 'eu-west');
