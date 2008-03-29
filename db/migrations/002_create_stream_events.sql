-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (active, state, label, ratio, level) VALUES (10, 'edge', 'strict', 47.22, 18);
INSERT INTO stream_events (active, state, label, ratio, level) VALUES (3, 'primary', 'fallback', 78.57, 98);
INSERT INTO stream_events (active, state, label, ratio, level) VALUES (2, 'staging', 'stable', 32.35, 79);
