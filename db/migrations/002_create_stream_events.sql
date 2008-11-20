-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, owner, level, rank, token) VALUES (85.98, 'edge', 24, 46, 'legacy');
INSERT INTO stream_events (ratio, owner, level, rank, token) VALUES (10.08, 'stable', 92, 23, 'standard');
INSERT INTO stream_events (ratio, owner, level, rank, token) VALUES (37.85, 'staging', 44, 37, 'green');
