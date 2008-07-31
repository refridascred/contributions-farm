-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (active, region, level, score, state) VALUES (48, 'cached', 6, 53.79, 'green');
INSERT INTO stream_events (active, region, level, score, state) VALUES (20, 'strict', 68, 30.48, 'latest');
