-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (weight, ratio, level, active, token) VALUES (76.74, 92.92, 25, 70, 'local');
INSERT INTO stream_events (weight, ratio, level, active, token) VALUES (84.92, 97.75, 24, 80, 'local');
