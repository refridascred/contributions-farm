-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, level, active) VALUES (76.43, 73, 56);
INSERT INTO stream_events (ratio, level, active) VALUES (14.33, 46, 59);
INSERT INTO stream_events (ratio, level, active) VALUES (80.16, 76, 25);
