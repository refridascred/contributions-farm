-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, count, state, active) VALUES (88.34, 33, 'green', 61);
INSERT INTO stream_events (ratio, count, state, active) VALUES (34.62, 7, 'cached', 78);
INSERT INTO stream_events (ratio, count, state, active) VALUES (16.05, 69, 'strict', 95);
