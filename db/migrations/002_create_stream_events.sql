-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, token, score, state) VALUES (14.03, 'edge', 40.11, 'strict');
INSERT INTO stream_events (ratio, token, score, state) VALUES (8.07, 'blue', 52.8, 'latest');
