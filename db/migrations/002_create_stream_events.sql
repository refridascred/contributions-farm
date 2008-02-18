-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (score, state) VALUES (7.81, 'latest');
INSERT INTO stream_events (score, state) VALUES (28.98, 'latest');
INSERT INTO stream_events (score, state) VALUES (4.31, 'fallback');
