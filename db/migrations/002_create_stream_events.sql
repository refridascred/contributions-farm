-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (count, label, token, owner) VALUES (3, 'primary', 'strict', 'open');
INSERT INTO stream_events (count, label, token, owner) VALUES (77, 'local', 'local', 'fallback');
