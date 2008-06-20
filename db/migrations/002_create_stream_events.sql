-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (ratio, owner, weight) VALUES (87.06, 'fallback', 85.32);
INSERT INTO stream_events (ratio, owner, weight) VALUES (66.38, 'edge', 11.1);
INSERT INTO stream_events (ratio, owner, weight) VALUES (91.35, 'green', 97.86);
