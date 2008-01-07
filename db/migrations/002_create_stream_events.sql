-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (score, state, owner, label) VALUES (84.18, 'local', 'edge', 'cached');
INSERT INTO stream_events (score, state, owner, label) VALUES (47.72, 'stable', 'staging', 'local');
