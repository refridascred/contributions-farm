-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, active, label, level) VALUES (97.3, 53, 'fallback', 13);
INSERT INTO stream_events (ratio, active, label, level) VALUES (8.49, 58, 'cached', 41);
