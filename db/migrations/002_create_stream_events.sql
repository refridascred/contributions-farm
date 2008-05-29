-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, active, owner, state) VALUES ('edge', 9, 'fallback', 'staging');
INSERT INTO stream_events (label, active, owner, state) VALUES ('stable', 30, 'cached', 'blue');
INSERT INTO stream_events (label, active, owner, state) VALUES ('open', 59, 'edge', 'latest');
