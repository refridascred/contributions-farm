-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, level, state) VALUES (76.18, 30, 'local');
INSERT INTO stream_events (score, level, state) VALUES (81.16, 75, 'blue');
INSERT INTO stream_events (score, level, state) VALUES (92.37, 5, 'stable');
