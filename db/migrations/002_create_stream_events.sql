-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (score, active, owner, label, level) VALUES (41.7, 21, 'staging', 'fallback', 1);
INSERT INTO stream_events (score, active, owner, label, level) VALUES (22.36, 39, 'latest', 'local', 66);
INSERT INTO stream_events (score, active, owner, label, level) VALUES (54.76, 42, 'cached', 'eu-west', 49);
