-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, ratio, owner, count) VALUES ('local', 75.55, 'green', 75);
INSERT INTO stream_events (token, ratio, owner, count) VALUES ('legacy', 0.82, 'edge', 21);
