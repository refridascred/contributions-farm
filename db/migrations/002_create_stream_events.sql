-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, level, active, weight) VALUES (97.74, 45, 13, 77.17);
INSERT INTO stream_events (ratio, level, active, weight) VALUES (45.47, 79, 21, 72.25);
INSERT INTO stream_events (ratio, level, active, weight) VALUES (73.68, 46, 30, 78.94);
