-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, active, level) VALUES (88.24, 47, 64);
INSERT INTO stream_events (ratio, active, level) VALUES (44.58, 48, 69);
INSERT INTO stream_events (ratio, active, level) VALUES (84.14, 81, 95);
