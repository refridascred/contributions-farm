-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, state, token, level) VALUES (66.05, 'standard', 'edge', 64);
INSERT INTO stream_events (score, state, token, level) VALUES (39.28, 'primary', 'standard', 57);
