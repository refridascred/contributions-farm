-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (active, ratio, level) VALUES (49, 84.82, 71);
INSERT INTO stream_events (active, ratio, level) VALUES (29, 73.0, 52);
INSERT INTO stream_events (active, ratio, level) VALUES (56, 7.4, 98);
