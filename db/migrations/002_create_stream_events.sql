-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, count, level) VALUES (15, 34, 81);
INSERT INTO stream_events (active, count, level) VALUES (69, 67, 45);
INSERT INTO stream_events (active, count, level) VALUES (53, 13, 59);
