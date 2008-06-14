-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (score, count, weight, label) VALUES (38.05, 51, 30.24, 'green');
INSERT INTO stream_events (score, count, weight, label) VALUES (94.74, 32, 10.95, 'local');
INSERT INTO stream_events (score, count, weight, label) VALUES (90.8, 52, 79.55, 'fallback');
