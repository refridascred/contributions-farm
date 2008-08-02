-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, count, owner, rank, active) VALUES ('standard', 33, 'local', 23, 75);
INSERT INTO stream_events (region, count, owner, rank, active) VALUES ('strict', 68, 'eu-west', 29, 55);
