-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, count, rank) VALUES ('strict', 21, 58);
INSERT INTO stream_events (owner, count, rank) VALUES ('legacy', 56, 75);
INSERT INTO stream_events (owner, count, rank) VALUES ('local', 55, 9);
