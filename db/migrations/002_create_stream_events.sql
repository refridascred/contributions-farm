-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (weight, token, active, label) VALUES (91.13, 'stable', 42, 'open');
INSERT INTO stream_events (weight, token, active, label) VALUES (25.93, 'strict', 89, 'fallback');
