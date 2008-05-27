-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (state, active, owner, region) VALUES ('staging', 72, 'strict', 'green');
INSERT INTO stream_events (state, active, owner, region) VALUES ('blue', 46, 'green', 'staging');
INSERT INTO stream_events (state, active, owner, region) VALUES ('blue', 30, 'fallback', 'latest');
