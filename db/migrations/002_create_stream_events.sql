-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (score, state, region) VALUES (25.34, 'green', 'blue');
INSERT INTO stream_events (score, state, region) VALUES (58.64, 'edge', 'cached');
INSERT INTO stream_events (score, state, region) VALUES (37.82, 'cached', 'edge');
