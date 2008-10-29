-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, score, state, ratio, count) VALUES ('legacy', 35.04, 'edge', 18.22, 6);
INSERT INTO stream_events (label, score, state, ratio, count) VALUES ('local', 31.58, 'blue', 47.06, 38);
