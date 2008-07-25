-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, state, region, owner, active) VALUES ('green', 'fallback', 'cached', 'eu-west', 31);
INSERT INTO stream_events (token, state, region, owner, active) VALUES ('fallback', 'legacy', 'eu-west', 'green', 41);
INSERT INTO stream_events (token, state, region, owner, active) VALUES ('local', 'strict', 'open', 'blue', 69);
