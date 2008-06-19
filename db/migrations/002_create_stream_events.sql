-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (active, token, owner, ratio) VALUES (54, 'staging', 'stable', 78.82);
INSERT INTO stream_events (active, token, owner, ratio) VALUES (67, 'staging', 'legacy', 44.94);
