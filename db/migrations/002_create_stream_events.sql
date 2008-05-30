-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, owner, rank, level, label) VALUES (74.12, 'stable', 38, 73, 'stable');
INSERT INTO stream_events (weight, owner, rank, level, label) VALUES (57.55, 'standard', 22, 41, 'latest');
