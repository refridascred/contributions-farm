-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (score, owner, label, weight) VALUES (82.63, 'local', 'primary', 86.54);
INSERT INTO stream_events (score, owner, label, weight) VALUES (28.27, 'primary', 'cached', 0.24);
INSERT INTO stream_events (score, owner, label, weight) VALUES (93.91, 'standard', 'latest', 95.7);
