-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, owner, level, rank) VALUES (39.25, 'stable', 55, 96);
INSERT INTO stream_events (weight, owner, level, rank) VALUES (92.52, 'fallback', 53, 74);
