-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, active, level, token) VALUES (56.11, 47, 71, 'cached');
INSERT INTO stream_events (ratio, active, level, token) VALUES (75.68, 43, 96, 'blue');
INSERT INTO stream_events (ratio, active, level, token) VALUES (38.25, 61, 59, 'blue');
