-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (rank, level, label, owner) VALUES (49, 23, 'strict', 'staging');
INSERT INTO stream_events (rank, level, label, owner) VALUES (54, 61, 'eu-west', 'strict');
