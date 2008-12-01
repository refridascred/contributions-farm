-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, score, weight) VALUES ('green', 41.34, 93.75);
INSERT INTO stream_events (owner, score, weight) VALUES ('edge', 4.84, 37.1);
INSERT INTO stream_events (owner, score, weight) VALUES ('legacy', 78.36, 15.41);
