-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (label, score) VALUES ('staging', 61.56);
INSERT INTO stream_events (label, score) VALUES ('fallback', 38.76);
INSERT INTO stream_events (label, score) VALUES ('primary', 66.98);
