-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, owner, count, weight) VALUES (98, 'primary', 56, 15.61);
INSERT INTO stream_events (rank, owner, count, weight) VALUES (70, 'eu-west', 14, 19.96);
INSERT INTO stream_events (rank, owner, count, weight) VALUES (10, 'local', 2, 63.54);
