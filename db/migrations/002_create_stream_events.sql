-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (level, active, state, label) VALUES (98, 19, 'cached', 'primary');
INSERT INTO stream_events (level, active, state, label) VALUES (46, 44, 'cached', 'primary');
INSERT INTO stream_events (level, active, state, label) VALUES (15, 55, 'legacy', 'primary');
