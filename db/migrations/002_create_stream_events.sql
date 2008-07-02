-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, label, owner, active, score) VALUES ('primary', 'fallback', 'strict', 80, 16.55);
INSERT INTO stream_events (token, label, owner, active, score) VALUES ('primary', 'latest', 'blue', 91, 79.68);
INSERT INTO stream_events (token, label, owner, active, score) VALUES ('latest', 'latest', 'local', 19, 42.27);
