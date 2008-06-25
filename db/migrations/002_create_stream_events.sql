-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, score) VALUES ('latest', 40.3);
INSERT INTO stream_events (label, score) VALUES ('local', 7.18);
INSERT INTO stream_events (label, score) VALUES ('staging', 75.58);
