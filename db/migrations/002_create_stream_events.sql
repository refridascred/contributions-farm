-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (ratio, active, count, owner, level) VALUES (44.55, 85, 38, 'stable', 99);
INSERT INTO stream_events (ratio, active, count, owner, level) VALUES (12.35, 20, 91, 'latest', 18);
INSERT INTO stream_events (ratio, active, count, owner, level) VALUES (77.53, 9, 45, 'stable', 21);
