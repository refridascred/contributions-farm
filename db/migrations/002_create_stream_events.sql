-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (active, owner, weight) VALUES (79, 'blue', 96.69);
INSERT INTO stream_events (active, owner, weight) VALUES (51, 'edge', 32.73);
INSERT INTO stream_events (active, owner, weight) VALUES (54, 'primary', 34.95);
