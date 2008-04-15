-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, count, token, label, rank) VALUES ('legacy', 98, 'standard', 'fallback', 43);
INSERT INTO stream_events (owner, count, token, label, rank) VALUES ('blue', 30, 'primary', 'fallback', 39);
