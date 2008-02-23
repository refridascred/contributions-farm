-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, owner, active) VALUES (0.68, 'fallback', 60);
INSERT INTO stream_events (ratio, owner, active) VALUES (65.8, 'blue', 69);
INSERT INTO stream_events (ratio, owner, active) VALUES (54.85, 'latest', 83);
