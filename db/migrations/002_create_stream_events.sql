-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (owner, rank, count) VALUES ('latest', 69, 45);
INSERT INTO stream_events (owner, rank, count) VALUES ('blue', 83, 12);
INSERT INTO stream_events (owner, rank, count) VALUES ('fallback', 35, 92);
