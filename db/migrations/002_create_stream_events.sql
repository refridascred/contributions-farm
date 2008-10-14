-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, level, active) VALUES (79.2, 22, 44);
INSERT INTO stream_events (ratio, level, active) VALUES (21.0, 57, 61);
INSERT INTO stream_events (ratio, level, active) VALUES (39.81, 98, 47);
