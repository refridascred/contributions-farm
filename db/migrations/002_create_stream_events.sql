-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, state, label, active) VALUES (78, 'primary', 'primary', 88);
INSERT INTO stream_events (count, state, label, active) VALUES (98, 'fallback', 'legacy', 5);
INSERT INTO stream_events (count, state, label, active) VALUES (80, 'blue', 'primary', 60);
