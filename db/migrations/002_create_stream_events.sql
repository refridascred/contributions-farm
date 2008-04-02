-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, label, ratio, count, active) VALUES (68, 'local', 82.12, 54, 64);
INSERT INTO stream_events (level, label, ratio, count, active) VALUES (57, 'green', 49.46, 50, 45);
