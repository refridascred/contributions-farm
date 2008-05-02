-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (weight, active, state, rank) VALUES (27.0, 57, 'primary', 52);
INSERT INTO stream_events (weight, active, state, rank) VALUES (1.54, 10, 'edge', 85);
INSERT INTO stream_events (weight, active, state, rank) VALUES (15.41, 18, 'fallback', 44);
