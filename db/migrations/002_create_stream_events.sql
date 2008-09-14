-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (count, active, state, label) VALUES (3, 33, 'stable', 'blue');
INSERT INTO stream_events (count, active, state, label) VALUES (12, 2, 'legacy', 'staging');
INSERT INTO stream_events (count, active, state, label) VALUES (91, 86, 'edge', 'staging');
