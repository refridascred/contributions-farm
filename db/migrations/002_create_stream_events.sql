-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, weight, owner) VALUES (65, 74.75, 'latest');
INSERT INTO stream_events (active, weight, owner) VALUES (91, 46.94, 'eu-west');
INSERT INTO stream_events (active, weight, owner) VALUES (63, 20.07, 'blue');
