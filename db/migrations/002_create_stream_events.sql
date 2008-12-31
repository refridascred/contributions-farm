-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, state, active, level) VALUES ('edge', 'strict', 52, 51);
INSERT INTO stream_events (label, state, active, level) VALUES ('primary', 'blue', 38, 64);
INSERT INTO stream_events (label, state, active, level) VALUES ('fallback', 'standard', 73, 39);
