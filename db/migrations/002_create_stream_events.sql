-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (active, score, label, owner, token) VALUES (5, 43.89, 'blue', 'fallback', 'primary');
INSERT INTO stream_events (active, score, label, owner, token) VALUES (75, 12.0, 'stable', 'blue', 'cached');
