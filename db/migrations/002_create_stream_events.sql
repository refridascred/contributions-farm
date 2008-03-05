-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (count, state, active) VALUES (40, 'primary', 84);
INSERT INTO stream_events (count, state, active) VALUES (83, 'legacy', 38);
INSERT INTO stream_events (count, state, active) VALUES (15, 'standard', 66);
