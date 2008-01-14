-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, level, active) VALUES (27.64, 43, 18);
INSERT INTO stream_events (ratio, level, active) VALUES (68.08, 7, 40);
INSERT INTO stream_events (ratio, level, active) VALUES (91.31, 51, 62);
