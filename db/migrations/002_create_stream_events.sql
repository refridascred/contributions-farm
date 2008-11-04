-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (score, ratio, count, active) VALUES (95.63, 86.79, 46, 62);
INSERT INTO stream_events (score, ratio, count, active) VALUES (24.49, 53.64, 96, 33);
INSERT INTO stream_events (score, ratio, count, active) VALUES (48.63, 19.58, 66, 6);
