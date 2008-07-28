-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, state, active, owner, score) VALUES ('open', 'green', 71, 'primary', 33.29);
INSERT INTO stream_events (label, state, active, owner, score) VALUES ('green', 'edge', 1, 'staging', 2.56);
INSERT INTO stream_events (label, state, active, owner, score) VALUES ('staging', 'edge', 36, 'open', 59.24);
