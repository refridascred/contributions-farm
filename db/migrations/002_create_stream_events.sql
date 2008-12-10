-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, state, active, weight) VALUES (33.68, 'standard', 5, 19.87);
INSERT INTO stream_events (ratio, state, active, weight) VALUES (79.02, 'stable', 96, 36.47);
INSERT INTO stream_events (ratio, state, active, weight) VALUES (14.74, 'fallback', 65, 88.84);
