-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (score, weight, label) VALUES (29.84, 44.4, 'stable');
INSERT INTO stream_events (score, weight, label) VALUES (43.9, 56.15, 'blue');
INSERT INTO stream_events (score, weight, label) VALUES (2.69, 72.12, 'cached');
