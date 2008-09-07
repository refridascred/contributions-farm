-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, rank) VALUES ('eu-west', 92);
INSERT INTO stream_events (owner, rank) VALUES ('stable', 47);
INSERT INTO stream_events (owner, rank) VALUES ('edge', 1);
