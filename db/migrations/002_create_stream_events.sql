-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, level, owner, state, token) VALUES ('fallback', 8, 'eu-west', 'blue', 'green');
INSERT INTO stream_events (region, level, owner, state, token) VALUES ('open', 8, 'stable', 'local', 'eu-west');
