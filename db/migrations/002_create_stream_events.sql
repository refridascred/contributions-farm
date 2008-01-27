-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (ratio, count, label, score, owner) VALUES (53.3, 3, 'strict', 67.12, 'primary');
INSERT INTO stream_events (ratio, count, label, score, owner) VALUES (21.22, 23, 'green', 16.57, 'staging');
