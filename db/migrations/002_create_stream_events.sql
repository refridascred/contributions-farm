-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, state, score, count, token) VALUES (37.74, 'stable', 32.9, 80, 'latest');
INSERT INTO stream_events (ratio, state, score, count, token) VALUES (58.52, 'primary', 90.83, 64, 'latest');
INSERT INTO stream_events (ratio, state, score, count, token) VALUES (74.98, 'latest', 45.11, 51, 'primary');
