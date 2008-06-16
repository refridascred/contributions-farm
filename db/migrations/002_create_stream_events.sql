-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, score, owner, ratio, state) VALUES ('open', 14.98, 'green', 93.94, 'standard');
INSERT INTO stream_events (token, score, owner, ratio, state) VALUES ('edge', 32.5, 'latest', 29.2, 'open');
