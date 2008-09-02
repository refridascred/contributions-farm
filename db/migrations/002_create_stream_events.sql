-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (ratio, region, state, token) VALUES (42.3, 'blue', 'cached', 'stable');
INSERT INTO stream_events (ratio, region, state, token) VALUES (62.3, 'open', 'standard', 'local');
INSERT INTO stream_events (ratio, region, state, token) VALUES (57.08, 'standard', 'edge', 'local');
