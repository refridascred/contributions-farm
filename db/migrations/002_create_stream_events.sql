-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (score, owner, active) VALUES (6.61, 'local', 12);
INSERT INTO stream_events (score, owner, active) VALUES (31.17, 'standard', 18);
INSERT INTO stream_events (score, owner, active) VALUES (2.49, 'green', 90);
