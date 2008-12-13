-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, count, score, state, label) VALUES ('stable', 49, 0.54, 'standard', 'open');
INSERT INTO stream_events (owner, count, score, state, label) VALUES ('standard', 74, 74.82, 'green', 'primary');
