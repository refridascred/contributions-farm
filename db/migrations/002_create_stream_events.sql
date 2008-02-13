-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, owner, level) VALUES ('local', 'legacy', 42);
INSERT INTO stream_events (label, owner, level) VALUES ('stable', 'fallback', 96);
