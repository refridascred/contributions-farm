-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, weight, label, score, owner) VALUES ('staging', 58.33, 'primary', 10.44, 'stable');
INSERT INTO stream_events (token, weight, label, score, owner) VALUES ('primary', 80.8, 'fallback', 86.97, 'cached');
