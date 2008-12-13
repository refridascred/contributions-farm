-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, owner, ratio) VALUES ('stable', 'legacy', 73.36);
INSERT INTO stream_events (token, owner, ratio) VALUES ('eu-west', 'edge', 6.46);
