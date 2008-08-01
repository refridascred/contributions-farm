-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, rank, count) VALUES ('strict', 94, 75);
INSERT INTO stream_events (owner, rank, count) VALUES ('open', 32, 21);
INSERT INTO stream_events (owner, rank, count) VALUES ('local', 19, 45);
