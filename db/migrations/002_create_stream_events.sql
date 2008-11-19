-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, count, active) VALUES (13, 5, 51);
INSERT INTO stream_events (level, count, active) VALUES (80, 49, 59);
INSERT INTO stream_events (level, count, active) VALUES (62, 64, 35);
