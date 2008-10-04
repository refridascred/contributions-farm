-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (level, region, token, count, owner) VALUES (71, 'strict', 'primary', 23, 'cached');
INSERT INTO stream_events (level, region, token, count, owner) VALUES (4, 'stable', 'legacy', 84, 'local');
