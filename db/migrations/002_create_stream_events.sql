-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, level, state, weight) VALUES ('standard', 84, 'open', 15.86);
INSERT INTO stream_events (label, level, state, weight) VALUES ('staging', 98, 'fallback', 51.99);
INSERT INTO stream_events (label, level, state, weight) VALUES ('legacy', 73, 'legacy', 85.08);
