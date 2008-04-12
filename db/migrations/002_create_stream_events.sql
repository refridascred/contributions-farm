-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, state, active) VALUES (41.23, 'staging', 68);
INSERT INTO stream_events (weight, state, active) VALUES (95.16, 'standard', 87);
INSERT INTO stream_events (weight, state, active) VALUES (82.65, 'stable', 71);
