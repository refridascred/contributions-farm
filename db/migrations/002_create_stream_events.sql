-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (label, state, ratio, active) VALUES ('strict', 'legacy', 85.31, 14);
INSERT INTO stream_events (label, state, ratio, active) VALUES ('green', 'blue', 41.12, 62);
