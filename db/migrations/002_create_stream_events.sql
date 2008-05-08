-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (level, active, count, ratio, weight) VALUES (64, 84, 60, 77.18, 91.71);
INSERT INTO stream_events (level, active, count, ratio, weight) VALUES (50, 72, 90, 47.63, 57.18);
