-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, active, weight) VALUES ('cached', 95, 61.11);
INSERT INTO stream_events (owner, active, weight) VALUES ('staging', 34, 46.45);
INSERT INTO stream_events (owner, active, weight) VALUES ('stable', 99, 3.71);
