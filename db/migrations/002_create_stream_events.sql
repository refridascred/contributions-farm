-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, state, level) VALUES ('latest', 'edge', 5);
INSERT INTO stream_events (token, state, level) VALUES ('latest', 'legacy', 27);
INSERT INTO stream_events (token, state, level) VALUES ('green', 'edge', 1);
