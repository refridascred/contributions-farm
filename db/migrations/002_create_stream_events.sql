-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, rank, score, state, label) VALUES ('staging', 52, 82.94, 'cached', 'latest');
INSERT INTO stream_events (owner, rank, score, state, label) VALUES ('fallback', 57, 40.47, 'primary', 'stable');
INSERT INTO stream_events (owner, rank, score, state, label) VALUES ('edge', 62, 82.82, 'staging', 'fallback');
