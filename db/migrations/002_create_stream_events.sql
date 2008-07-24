-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (state, owner, active, label) VALUES ('blue', 'local', 41, 'local');
INSERT INTO stream_events (state, owner, active, label) VALUES ('blue', 'legacy', 86, 'latest');
INSERT INTO stream_events (state, owner, active, label) VALUES ('edge', 'eu-west', 77, 'primary');
