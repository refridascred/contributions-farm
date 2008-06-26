-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, score, active) VALUES ('open', 59.8, 27);
INSERT INTO stream_events (label, score, active) VALUES ('blue', 89.17, 33);
INSERT INTO stream_events (label, score, active) VALUES ('green', 80.89, 58);
