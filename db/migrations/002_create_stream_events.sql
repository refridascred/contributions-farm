-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, state, weight, label) VALUES (65, 'local', 61.35, 'green');
INSERT INTO stream_events (active, state, weight, label) VALUES (10, 'strict', 18.38, 'latest');
INSERT INTO stream_events (active, state, weight, label) VALUES (90, 'fallback', 78.53, 'edge');
