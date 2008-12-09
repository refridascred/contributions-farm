-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, region, owner, score) VALUES (1, 'local', 'edge', 28.39);
INSERT INTO stream_events (level, region, owner, score) VALUES (42, 'stable', 'local', 18.11);
INSERT INTO stream_events (level, region, owner, score) VALUES (62, 'primary', 'standard', 89.36);
