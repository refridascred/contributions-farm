-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (level, owner, weight, active) VALUES (45, 'eu-west', 91.77, 32);
