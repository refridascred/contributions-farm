-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (active, score, label, owner, token) VALUES (73, 6.45, 'legacy', 'cached', 'latest');
INSERT INTO stream_events (active, score, label, owner, token) VALUES (56, 44.95, 'legacy', 'latest', 'primary');
