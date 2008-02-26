-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (score, owner, label) VALUES (41.23, 'standard', 'blue');
INSERT INTO stream_events (score, owner, label) VALUES (8.55, 'staging', 'blue');
INSERT INTO stream_events (score, owner, label) VALUES (62.84, 'strict', 'open');
