-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, region, state, active) VALUES (55, 'strict', 'fallback', 23);
INSERT INTO stream_events (level, region, state, active) VALUES (1, 'legacy', 'fallback', 28);
INSERT INTO stream_events (level, region, state, active) VALUES (69, 'local', 'blue', 2);
