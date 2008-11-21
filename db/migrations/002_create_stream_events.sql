-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (count, token, owner, rank) VALUES (75, 'eu-west', 'open', 45);
INSERT INTO stream_events (count, token, owner, rank) VALUES (51, 'blue', 'eu-west', 97);
INSERT INTO stream_events (count, token, owner, rank) VALUES (72, 'staging', 'strict', 44);
