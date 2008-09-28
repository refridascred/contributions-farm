-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, level, owner, rank, region) VALUES (75, 94, 'fallback', 84, 'blue');
INSERT INTO stream_events (count, level, owner, rank, region) VALUES (3, 97, 'fallback', 88, 'stable');
INSERT INTO stream_events (count, level, owner, rank, region) VALUES (15, 50, 'blue', 26, 'fallback');
