-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (token, active, region, state, owner) VALUES ('green', 2, 'blue', 'eu-west', 'local');
INSERT INTO stream_events (token, active, region, state, owner) VALUES ('edge', 21, 'staging', 'blue', 'staging');
