-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, owner, ratio, weight) VALUES ('edge', 'edge', 83.28, 55.1);
INSERT INTO stream_events (label, owner, ratio, weight) VALUES ('green', 'fallback', 98.88, 30.58);
INSERT INTO stream_events (label, owner, ratio, weight) VALUES ('standard', 'strict', 26.48, 90.79);
