-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (count, weight, ratio, level, owner) VALUES (18, 93.22, 90.67, 67, 'edge');
INSERT INTO stream_events (count, weight, ratio, level, owner) VALUES (97, 70.77, 42.1, 84, 'staging');
