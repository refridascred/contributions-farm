-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, owner, count, weight, active) VALUES (77.44, 'open', 73, 58.93, 91);
INSERT INTO stream_events (ratio, owner, count, weight, active) VALUES (2.41, 'open', 97, 33.15, 80);
INSERT INTO stream_events (ratio, owner, count, weight, active) VALUES (46.23, 'staging', 11, 53.12, 10);
