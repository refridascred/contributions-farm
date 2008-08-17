-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (state, active, owner, label) VALUES ('green', 40, 'latest', 'local');
INSERT INTO stream_events (state, active, owner, label) VALUES ('legacy', 54, 'latest', 'standard');
INSERT INTO stream_events (state, active, owner, label) VALUES ('edge', 88, 'fallback', 'staging');
