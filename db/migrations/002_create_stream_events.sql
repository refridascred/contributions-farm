-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    owner TEXT NOT NULL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, level, owner, region, rank) VALUES (44, 21, 'legacy', 'fallback', 29);
INSERT INTO stream_events (active, level, owner, region, rank) VALUES (13, 38, 'stable', 'eu-west', 37);
