-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, score, ratio) VALUES ('edge', 74.15, 41.0);
INSERT INTO stream_events (label, score, ratio) VALUES ('blue', 38.87, 61.27);
INSERT INTO stream_events (label, score, ratio) VALUES ('stable', 27.19, 18.08);
