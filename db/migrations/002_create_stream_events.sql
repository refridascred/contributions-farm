-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, label, rank, owner, active) VALUES (57.06, 'eu-west', 27, 'eu-west', 7);
INSERT INTO stream_events (weight, label, rank, owner, active) VALUES (59.02, 'blue', 54, 'edge', 20);
