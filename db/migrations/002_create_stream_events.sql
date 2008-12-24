-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (label, owner, state) VALUES ('eu-west', 'fallback', 'strict');
INSERT INTO stream_events (label, owner, state) VALUES ('edge', 'cached', 'staging');
