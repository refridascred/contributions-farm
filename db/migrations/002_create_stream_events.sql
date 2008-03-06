-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (label, state, count, active) VALUES ('eu-west', 'edge', 9, 88);
INSERT INTO stream_events (label, state, count, active) VALUES ('strict', 'primary', 74, 88);
INSERT INTO stream_events (label, state, count, active) VALUES ('legacy', 'cached', 63, 0);
