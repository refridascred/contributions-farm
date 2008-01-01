-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, state, weight, level) VALUES ('primary', 'legacy', 49.48, 65);
INSERT INTO stream_events (region, state, weight, level) VALUES ('legacy', 'fallback', 24.3, 42);
