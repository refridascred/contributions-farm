-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, region, score, level, weight) VALUES ('staging', 'cached', 94.68, 67, 61.23);
INSERT INTO stream_events (label, region, score, level, weight) VALUES ('standard', 'green', 30.6, 61, 95.65);
