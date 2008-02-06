-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, token, level, state) VALUES (22.51, 'legacy', 25, 'cached');
INSERT INTO stream_events (score, token, level, state) VALUES (14.47, 'strict', 6, 'cached');
