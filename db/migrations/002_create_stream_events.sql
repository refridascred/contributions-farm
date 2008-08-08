-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (count, label, owner, score) VALUES (57, 'cached', 'latest', 92.42);
INSERT INTO stream_events (count, label, owner, score) VALUES (93, 'open', 'staging', 46.81);
INSERT INTO stream_events (count, label, owner, score) VALUES (9, 'standard', 'latest', 81.02);
