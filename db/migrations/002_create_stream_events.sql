-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, region, active, label, token) VALUES ('edge', 'standard', 20, 'local', 'local');
INSERT INTO stream_events (state, region, active, label, token) VALUES ('staging', 'fallback', 7, 'primary', 'stable');
INSERT INTO stream_events (state, region, active, label, token) VALUES ('stable', 'local', 76, 'fallback', 'open');
