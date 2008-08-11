-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, score, count) VALUES ('primary', 6.89, 58);
INSERT INTO stream_events (owner, score, count) VALUES ('standard', 20.36, 95);
INSERT INTO stream_events (owner, score, count) VALUES ('blue', 77.98, 6);
