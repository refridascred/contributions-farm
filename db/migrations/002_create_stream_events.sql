-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (label, level, active, rank) VALUES ('green', 65, 95, 4);
INSERT INTO stream_events (label, level, active, rank) VALUES ('eu-west', 52, 42, 22);
INSERT INTO stream_events (label, level, active, rank) VALUES ('edge', 90, 90, 10);
