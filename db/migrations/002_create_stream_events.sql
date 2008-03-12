-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (state, score) VALUES ('primary', 0.04);
INSERT INTO stream_events (state, score) VALUES ('eu-west', 26.32);
INSERT INTO stream_events (state, score) VALUES ('fallback', 79.14);
