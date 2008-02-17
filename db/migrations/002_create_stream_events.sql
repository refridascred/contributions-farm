-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, label, weight, active, ratio) VALUES (62.22, 'green', 83.19, 57, 38.04);
INSERT INTO stream_events (score, label, weight, active, ratio) VALUES (60.43, 'open', 59.06, 40, 71.28);
INSERT INTO stream_events (score, label, weight, active, ratio) VALUES (48.01, 'latest', 24.75, 3, 2.03);
