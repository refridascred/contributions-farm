-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, weight, state, active) VALUES (86, 23.41, 'stable', 5);
