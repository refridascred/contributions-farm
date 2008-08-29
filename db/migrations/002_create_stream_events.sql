-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, state) VALUES ('staging', 'local');
INSERT INTO stream_events (owner, state) VALUES ('fallback', 'standard');
INSERT INTO stream_events (owner, state) VALUES ('open', 'local');
