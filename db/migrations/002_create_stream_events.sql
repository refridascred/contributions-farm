-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, level, active) VALUES (92.94, 39, 62);
INSERT INTO stream_events (ratio, level, active) VALUES (9.7, 52, 29);
INSERT INTO stream_events (ratio, level, active) VALUES (33.08, 8, 19);
