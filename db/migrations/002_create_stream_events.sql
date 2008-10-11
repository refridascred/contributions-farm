-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, count, level, label, owner) VALUES ('edge', 30, 7, 'blue', 'eu-west');
INSERT INTO stream_events (region, count, level, label, owner) VALUES ('stable', 10, 32, 'stable', 'open');
INSERT INTO stream_events (region, count, level, label, owner) VALUES ('eu-west', 1, 92, 'cached', 'green');
