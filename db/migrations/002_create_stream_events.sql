-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, state, score, count, token) VALUES ('green', 'latest', 41.63, 7, 'stable');
INSERT INTO stream_events (region, state, score, count, token) VALUES ('local', 'standard', 41.34, 92, 'local');
INSERT INTO stream_events (region, state, score, count, token) VALUES ('legacy', 'strict', 20.11, 76, 'green');
