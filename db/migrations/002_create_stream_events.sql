-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (ratio, label, state) VALUES (20.34, 'legacy', 'fallback');
INSERT INTO stream_events (ratio, label, state) VALUES (2.02, 'edge', 'fallback');
INSERT INTO stream_events (ratio, label, state) VALUES (39.2, 'latest', 'strict');
