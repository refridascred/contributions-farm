-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, count, state) VALUES ('stable', 8, 'standard');
INSERT INTO stream_events (token, count, state) VALUES ('strict', 69, 'eu-west');
INSERT INTO stream_events (token, count, state) VALUES ('standard', 15, 'edge');
