-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, state, weight, level) VALUES ('standard', 'legacy', 63.1, 67);
INSERT INTO stream_events (label, state, weight, level) VALUES ('fallback', 'primary', 43.47, 38);
INSERT INTO stream_events (label, state, weight, level) VALUES ('latest', 'edge', 36.53, 90);
