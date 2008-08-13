-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, score) VALUES ('green', 42.59);
INSERT INTO stream_events (label, score) VALUES ('legacy', 22.34);
INSERT INTO stream_events (label, score) VALUES ('stable', 91.78);
