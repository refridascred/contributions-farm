-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, rank, level) VALUES ('stable', 41, 96);
INSERT INTO stream_events (owner, rank, level) VALUES ('green', 27, 83);
INSERT INTO stream_events (owner, rank, level) VALUES ('staging', 96, 98);
