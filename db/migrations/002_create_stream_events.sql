-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, rank, region, ratio, owner) VALUES (99, 64, 'fallback', 64.64, 'legacy');
INSERT INTO stream_events (level, rank, region, ratio, owner) VALUES (4, 36, 'local', 84.08, 'open');
