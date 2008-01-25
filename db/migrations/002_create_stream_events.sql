-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, active, rank, owner) VALUES (69.44, 17, 21, 'latest');
INSERT INTO stream_events (weight, active, rank, owner) VALUES (33.54, 57, 71, 'blue');
INSERT INTO stream_events (weight, active, rank, owner) VALUES (42.99, 25, 18, 'fallback');
