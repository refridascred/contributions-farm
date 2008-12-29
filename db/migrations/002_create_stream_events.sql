-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, active, state, label) VALUES (40.53, 49, 'standard', 'primary');
INSERT INTO stream_events (ratio, active, state, label) VALUES (57.41, 80, 'eu-west', 'fallback');
INSERT INTO stream_events (ratio, active, state, label) VALUES (83.08, 24, 'local', 'open');
