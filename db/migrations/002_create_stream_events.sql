-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (owner, count) VALUES ('cached', 0);
INSERT INTO stream_events (owner, count) VALUES ('local', 47);
INSERT INTO stream_events (owner, count) VALUES ('staging', 90);
