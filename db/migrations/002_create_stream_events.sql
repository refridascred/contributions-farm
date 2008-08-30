-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (score, state, level) VALUES (90.23, 'edge', 19);
INSERT INTO stream_events (score, state, level) VALUES (32.39, 'staging', 3);
INSERT INTO stream_events (score, state, level) VALUES (62.79, 'edge', 69);
