-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    label TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (weight, region, label, token, score) VALUES (90.17, 'stable', 'strict', 'edge', 6.39);
INSERT INTO stream_events (weight, region, label, token, score) VALUES (90.85, 'green', 'stable', 'fallback', 83.78);
INSERT INTO stream_events (weight, region, label, token, score) VALUES (18.42, 'cached', 'eu-west', 'edge', 64.11);
