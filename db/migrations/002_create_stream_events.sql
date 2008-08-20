-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, count, ratio, label, score) VALUES (77, 48, 80.83, 'eu-west', 43.13);
INSERT INTO stream_events (active, count, ratio, label, score) VALUES (7, 92, 46.88, 'staging', 7.65);
INSERT INTO stream_events (active, count, ratio, label, score) VALUES (34, 29, 57.72, 'fallback', 72.6);
