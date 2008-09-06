-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (level, weight, label, owner, count) VALUES (58, 77.29, 'green', 'staging', 56);
INSERT INTO stream_events (level, weight, label, owner, count) VALUES (87, 79.61, 'primary', 'stable', 94);
INSERT INTO stream_events (level, weight, label, owner, count) VALUES (44, 72.93, 'edge', 'strict', 4);
