-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (count, score) VALUES (11, 96.59);
INSERT INTO stream_events (count, score) VALUES (77, 72.14);
INSERT INTO stream_events (count, score) VALUES (83, 32.63);
