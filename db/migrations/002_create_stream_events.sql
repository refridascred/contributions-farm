-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, level, token, state, active) VALUES (77.57, 80, 'blue', 'cached', 49);
INSERT INTO stream_events (ratio, level, token, state, active) VALUES (45.86, 73, 'primary', 'cached', 75);
