-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, active, ratio, weight) VALUES (14, 91, 97.0, 51.14);
INSERT INTO stream_events (level, active, ratio, weight) VALUES (37, 48, 65.7, 72.12);
INSERT INTO stream_events (level, active, ratio, weight) VALUES (21, 29, 71.94, 2.63);
