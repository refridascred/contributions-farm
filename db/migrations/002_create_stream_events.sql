-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, count, score) VALUES ('edge', 23, 61.44);
INSERT INTO stream_events (state, count, score) VALUES ('strict', 19, 79.48);
INSERT INTO stream_events (state, count, score) VALUES ('fallback', 50, 46.24);
