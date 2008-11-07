-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (label, state, score, region) VALUES ('edge', 'local', 57.6, 'stable');
INSERT INTO stream_events (label, state, score, region) VALUES ('staging', 'stable', 59.77, 'edge');
INSERT INTO stream_events (label, state, score, region) VALUES ('local', 'open', 13.37, 'open');
