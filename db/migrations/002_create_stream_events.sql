-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, state, token, weight) VALUES (35, 'eu-west', 'local', 35.59);
INSERT INTO stream_events (active, state, token, weight) VALUES (94, 'strict', 'edge', 69.3);
INSERT INTO stream_events (active, state, token, weight) VALUES (60, 'local', 'staging', 35.05);
