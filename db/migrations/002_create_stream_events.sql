-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, label, score, count) VALUES ('latest', 'fallback', 10.06, 22);
INSERT INTO stream_events (owner, label, score, count) VALUES ('local', 'blue', 54.9, 41);
INSERT INTO stream_events (owner, label, score, count) VALUES ('green', 'staging', 65.29, 1);
