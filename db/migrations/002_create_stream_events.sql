-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (count, owner, rank) VALUES (71, 'local', 18);
INSERT INTO stream_events (count, owner, rank) VALUES (58, 'eu-west', 48);
INSERT INTO stream_events (count, owner, rank) VALUES (68, 'eu-west', 51);
