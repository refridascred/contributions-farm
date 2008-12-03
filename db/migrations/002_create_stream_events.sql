-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (label, ratio, level, active) VALUES ('staging', 83.3, 49, 93);
INSERT INTO stream_events (label, ratio, level, active) VALUES ('stable', 78.91, 61, 28);
INSERT INTO stream_events (label, ratio, level, active) VALUES ('fallback', 52.42, 20, 78);
