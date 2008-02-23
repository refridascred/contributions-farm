-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, active, score, weight) VALUES ('edge', 93, 12.7, 80.09);
INSERT INTO stream_events (label, active, score, weight) VALUES ('stable', 8, 91.43, 21.06);
