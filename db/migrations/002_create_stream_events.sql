-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, weight, owner) VALUES (63, 60.9, 'latest');
INSERT INTO stream_events (active, weight, owner) VALUES (22, 31.74, 'open');
INSERT INTO stream_events (active, weight, owner) VALUES (91, 13.2, 'standard');
