-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (label, active, count, state) VALUES ('primary', 32, 81, 'legacy');
INSERT INTO stream_events (label, active, count, state) VALUES ('stable', 1, 68, 'fallback');
