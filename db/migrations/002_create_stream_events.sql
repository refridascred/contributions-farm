-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (level, owner, state, region) VALUES (3, 'local', 'fallback', 'latest');
INSERT INTO stream_events (level, owner, state, region) VALUES (6, 'eu-west', 'stable', 'local');
INSERT INTO stream_events (level, owner, state, region) VALUES (90, 'strict', 'standard', 'green');
