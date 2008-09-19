-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, weight, state, count, token) VALUES (33, 1.15, 'green', 17, 'local');
INSERT INTO stream_events (level, weight, state, count, token) VALUES (13, 78.49, 'primary', 32, 'latest');
INSERT INTO stream_events (level, weight, state, count, token) VALUES (62, 16.5, 'standard', 31, 'strict');
