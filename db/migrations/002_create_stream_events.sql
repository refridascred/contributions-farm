-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, state, region, count) VALUES (0, 'stable', 'fallback', 35);
INSERT INTO stream_events (level, state, region, count) VALUES (78, 'open', 'edge', 84);
INSERT INTO stream_events (level, state, region, count) VALUES (5, 'eu-west', 'latest', 50);
