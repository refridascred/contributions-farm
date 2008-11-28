-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, owner, token, weight, score) VALUES ('standard', 'staging', 'staging', 96.62, 7.68);
INSERT INTO stream_events (label, owner, token, weight, score) VALUES ('fallback', 'cached', 'standard', 72.07, 30.34);
INSERT INTO stream_events (label, owner, token, weight, score) VALUES ('standard', 'standard', 'legacy', 8.38, 37.86);
