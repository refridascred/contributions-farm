-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (active, score, state, region) VALUES (64, 69.64, 'standard', 'open');
INSERT INTO stream_events (active, score, state, region) VALUES (67, 27.54, 'strict', 'latest');
INSERT INTO stream_events (active, score, state, region) VALUES (47, 47.5, 'eu-west', 'fallback');
