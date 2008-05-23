-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, state, token, region, count) VALUES ('fallback', 'standard', 'green', 'cached', 26);
INSERT INTO stream_events (owner, state, token, region, count) VALUES ('standard', 'eu-west', 'stable', 'cached', 44);
