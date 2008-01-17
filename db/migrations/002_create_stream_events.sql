-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, region, label, state, owner) VALUES (12, 'stable', 'stable', 'fallback', 'eu-west');
INSERT INTO stream_events (active, region, label, state, owner) VALUES (69, 'eu-west', 'local', 'eu-west', 'green');
INSERT INTO stream_events (active, region, label, state, owner) VALUES (89, 'local', 'cached', 'latest', 'fallback');
