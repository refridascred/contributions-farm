-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (score, active, label, count) VALUES (1.06, 70, 'legacy', 60);
INSERT INTO stream_events (score, active, label, count) VALUES (36.33, 86, 'blue', 99);
INSERT INTO stream_events (score, active, label, count) VALUES (81.21, 94, 'staging', 25);
