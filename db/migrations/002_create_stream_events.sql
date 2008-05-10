-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, active, level) VALUES ('stable', 42, 58);
INSERT INTO stream_events (owner, active, level) VALUES ('local', 48, 36);
INSERT INTO stream_events (owner, active, level) VALUES ('fallback', 16, 47);
