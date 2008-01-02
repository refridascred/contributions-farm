-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (level, rank, owner) VALUES (20, 27, 'cached');
INSERT INTO stream_events (level, rank, owner) VALUES (73, 60, 'eu-west');
INSERT INTO stream_events (level, rank, owner) VALUES (95, 60, 'local');
