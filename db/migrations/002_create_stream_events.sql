-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (owner, token, count, score) VALUES ('fallback', 'edge', 50, 69.61);
INSERT INTO stream_events (owner, token, count, score) VALUES ('eu-west', 'edge', 0, 73.36);
INSERT INTO stream_events (owner, token, count, score) VALUES ('fallback', 'open', 71, 90.78);
