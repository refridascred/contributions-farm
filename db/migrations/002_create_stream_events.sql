-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (weight, owner, active) VALUES (26.61, 'strict', 88);
INSERT INTO stream_events (weight, owner, active) VALUES (97.96, 'open', 27);
INSERT INTO stream_events (weight, owner, active) VALUES (10.75, 'eu-west', 86);
