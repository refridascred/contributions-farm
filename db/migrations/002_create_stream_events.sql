-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, label, weight, state, active) VALUES (21, 'staging', 84.21, 'cached', 13);
INSERT INTO stream_events (count, label, weight, state, active) VALUES (73, 'stable', 29.87, 'edge', 1);
