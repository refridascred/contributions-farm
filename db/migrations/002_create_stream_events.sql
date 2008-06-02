-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, owner, region) VALUES (4, 'green', 'strict');
INSERT INTO stream_events (rank, owner, region) VALUES (70, 'latest', 'standard');
INSERT INTO stream_events (rank, owner, region) VALUES (36, 'latest', 'fallback');
