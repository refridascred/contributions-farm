-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, ratio, active) VALUES ('standard', 41.09, 7);
INSERT INTO stream_events (owner, ratio, active) VALUES ('latest', 85.58, 67);
INSERT INTO stream_events (owner, ratio, active) VALUES ('stable', 2.13, 61);
