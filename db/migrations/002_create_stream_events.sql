-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, label, owner, count) VALUES (52, 'strict', 'strict', 30);
INSERT INTO stream_events (rank, label, owner, count) VALUES (47, 'local', 'eu-west', 8);
INSERT INTO stream_events (rank, label, owner, count) VALUES (75, 'fallback', 'blue', 49);
