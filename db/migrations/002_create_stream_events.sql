-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, rank, count, owner) VALUES ('strict', 9, 82, 'legacy');
INSERT INTO stream_events (token, rank, count, owner) VALUES ('open', 35, 70, 'open');
INSERT INTO stream_events (token, rank, count, owner) VALUES ('blue', 18, 98, 'open');
