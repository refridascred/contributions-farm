-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (label, score, count, active) VALUES ('strict', 83.0, 39, 26);
INSERT INTO stream_events (label, score, count, active) VALUES ('stable', 1.51, 93, 67);
INSERT INTO stream_events (label, score, count, active) VALUES ('eu-west', 82.83, 83, 14);
