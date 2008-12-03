-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, owner, count) VALUES ('edge', 'edge', 33);
INSERT INTO stream_events (token, owner, count) VALUES ('fallback', 'blue', 66);
INSERT INTO stream_events (token, owner, count) VALUES ('cached', 'green', 24);
