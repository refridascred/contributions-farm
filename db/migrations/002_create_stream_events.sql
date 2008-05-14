-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (label, weight, region, state, token) VALUES ('legacy', 6.15, 'legacy', 'legacy', 'staging');
INSERT INTO stream_events (label, weight, region, state, token) VALUES ('legacy', 94.37, 'staging', 'primary', 'edge');
INSERT INTO stream_events (label, weight, region, state, token) VALUES ('stable', 96.03, 'stable', 'green', 'latest');
