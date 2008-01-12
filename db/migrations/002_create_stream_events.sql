-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, rank, level, region, label) VALUES (4.99, 0, 62, 'cached', 'staging');
INSERT INTO stream_events (score, rank, level, region, label) VALUES (45.55, 21, 47, 'stable', 'latest');
INSERT INTO stream_events (score, rank, level, region, label) VALUES (98.33, 4, 87, 'stable', 'open');
