-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, active, level, count) VALUES ('green', 87, 32, 72);
INSERT INTO stream_events (owner, active, level, count) VALUES ('local', 62, 38, 82);
INSERT INTO stream_events (owner, active, level, count) VALUES ('green', 44, 86, 70);
