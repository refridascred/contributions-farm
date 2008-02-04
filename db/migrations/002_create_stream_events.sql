-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, owner, token, score, label) VALUES (26, 'green', 'standard', 42.19, 'primary');
INSERT INTO stream_events (level, owner, token, score, label) VALUES (96, 'local', 'staging', 38.9, 'edge');
INSERT INTO stream_events (level, owner, token, score, label) VALUES (93, 'local', 'legacy', 9.91, 'local');
