-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (ratio, owner, count, weight) VALUES (57.77, 'latest', 86, 22.93);
INSERT INTO stream_events (ratio, owner, count, weight) VALUES (77.94, 'eu-west', 93, 2.88);
