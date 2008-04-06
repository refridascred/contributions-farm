-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, rank) VALUES ('eu-west', 81);
INSERT INTO stream_events (owner, rank) VALUES ('stable', 11);
INSERT INTO stream_events (owner, rank) VALUES ('stable', 88);
