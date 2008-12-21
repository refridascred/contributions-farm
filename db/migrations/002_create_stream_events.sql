-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, ratio, count, owner) VALUES ('local', 98.46, 15, 'latest');
INSERT INTO stream_events (token, ratio, count, owner) VALUES ('standard', 76.8, 22, 'cached');
