-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (level, rank, owner, ratio) VALUES (48, 74, 'eu-west', 42.91);
INSERT INTO stream_events (level, rank, owner, ratio) VALUES (72, 97, 'latest', 4.14);
