-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, state) VALUES (2.67, 'strict');
INSERT INTO stream_events (score, state) VALUES (92.49, 'legacy');
INSERT INTO stream_events (score, state) VALUES (54.77, 'eu-west');
