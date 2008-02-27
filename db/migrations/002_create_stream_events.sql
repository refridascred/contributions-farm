-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, state, active) VALUES (46.56, 'blue', 97);
INSERT INTO stream_events (weight, state, active) VALUES (4.15, 'fallback', 48);
INSERT INTO stream_events (weight, state, active) VALUES (7.92, 'edge', 17);
