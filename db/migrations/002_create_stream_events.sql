-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, owner, state) VALUES (28, 'local', 'green');
INSERT INTO stream_events (active, owner, state) VALUES (93, 'eu-west', 'blue');
INSERT INTO stream_events (active, owner, state) VALUES (99, 'latest', 'edge');
