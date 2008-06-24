-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, label, score, state, token) VALUES ('blue', 'latest', 6.09, 'stable', 'stable');
INSERT INTO stream_events (region, label, score, state, token) VALUES ('edge', 'local', 69.38, 'local', 'local');
