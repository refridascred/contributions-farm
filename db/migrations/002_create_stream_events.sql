-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, level, owner, count) VALUES ('green', 72, 'cached', 77);
INSERT INTO stream_events (label, level, owner, count) VALUES ('blue', 21, 'fallback', 33);
