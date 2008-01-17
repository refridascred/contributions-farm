-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (active, region, label, state, weight) VALUES (6, 'legacy', 'legacy', 'standard', 87.54);
INSERT INTO stream_events (active, region, label, state, weight) VALUES (98, 'primary', 'stable', 'open', 56.51);
