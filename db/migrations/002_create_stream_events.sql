-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (level, label, weight, score) VALUES (33, 'standard', 63.76, 62.09);
INSERT INTO stream_events (level, label, weight, score) VALUES (23, 'cached', 3.43, 50.31);
INSERT INTO stream_events (level, label, weight, score) VALUES (60, 'local', 30.25, 88.98);
