-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (count, owner, level, active, region) VALUES (43, 'strict', 22, 39, 'edge');
INSERT INTO stream_events (count, owner, level, active, region) VALUES (14, 'local', 64, 4, 'legacy');
INSERT INTO stream_events (count, owner, level, active, region) VALUES (39, 'fallback', 19, 43, 'edge');
