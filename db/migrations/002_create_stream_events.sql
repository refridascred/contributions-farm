-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (owner, ratio, active, weight) VALUES ('green', 6.04, 85, 15.47);
INSERT INTO stream_events (owner, ratio, active, weight) VALUES ('green', 12.32, 31, 62.64);
INSERT INTO stream_events (owner, ratio, active, weight) VALUES ('strict', 3.78, 59, 84.19);
