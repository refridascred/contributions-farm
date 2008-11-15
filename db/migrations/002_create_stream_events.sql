-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (score, active, label, count, weight) VALUES (0.15, 83, 'legacy', 41, 56.78);
INSERT INTO stream_events (score, active, label, count, weight) VALUES (53.75, 70, 'primary', 67, 57.33);
INSERT INTO stream_events (score, active, label, count, weight) VALUES (0.35, 8, 'green', 97, 19.13);
