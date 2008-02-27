-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (level, active, weight, ratio, state) VALUES (6, 20, 4.14, 14.12, 'open');
INSERT INTO stream_events (level, active, weight, ratio, state) VALUES (19, 68, 63.85, 19.08, 'local');
