-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (score, level, active, label) VALUES (40.56, 43, 65, 'standard');
