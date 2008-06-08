-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (score, label, region, weight) VALUES (17.49, 'standard', 'cached', 63.57);
INSERT INTO stream_events (score, label, region, weight) VALUES (95.27, 'cached', 'legacy', 49.93);
INSERT INTO stream_events (score, label, region, weight) VALUES (14.53, 'fallback', 'edge', 0.46);
