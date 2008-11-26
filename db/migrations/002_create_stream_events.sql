-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, score, count, label, owner) VALUES (90, 58.74, 25, 'fallback', 'local');
INSERT INTO stream_events (level, score, count, label, owner) VALUES (33, 61.38, 5, 'local', 'fallback');
