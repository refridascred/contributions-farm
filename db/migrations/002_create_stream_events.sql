-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, active, score) VALUES ('fallback', 53, 31.28);
INSERT INTO stream_events (label, active, score) VALUES ('eu-west', 37, 59.32);
INSERT INTO stream_events (label, active, score) VALUES ('strict', 69, 13.75);
