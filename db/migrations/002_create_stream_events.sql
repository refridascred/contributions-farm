-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (active, rank, owner, level) VALUES (82, 17, 'blue', 2);
INSERT INTO stream_events (active, rank, owner, level) VALUES (37, 94, 'eu-west', 92);
INSERT INTO stream_events (active, rank, owner, level) VALUES (1, 56, 'staging', 5);
