-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, token, state) VALUES ('standard', 'stable', 'primary');
INSERT INTO stream_events (owner, token, state) VALUES ('staging', 'latest', 'primary');
INSERT INTO stream_events (owner, token, state) VALUES ('open', 'standard', 'cached');
