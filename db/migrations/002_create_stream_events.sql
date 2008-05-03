-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, owner, level) VALUES (53, 'stable', 11);
INSERT INTO stream_events (count, owner, level) VALUES (98, 'blue', 28);
INSERT INTO stream_events (count, owner, level) VALUES (91, 'edge', 35);
