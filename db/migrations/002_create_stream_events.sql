-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, level, count) VALUES ('blue', 19, 73);
INSERT INTO stream_events (label, level, count) VALUES ('legacy', 62, 57);
INSERT INTO stream_events (label, level, count) VALUES ('green', 61, 70);
