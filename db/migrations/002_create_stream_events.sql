-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, ratio, state, level, token) VALUES (67, 96.63, 'blue', 86, 'edge');
INSERT INTO stream_events (count, ratio, state, level, token) VALUES (54, 81.9, 'legacy', 52, 'primary');
