-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, score, owner) VALUES (85.38, 31.04, 'staging');
INSERT INTO stream_events (weight, score, owner) VALUES (94.25, 13.84, 'green');
INSERT INTO stream_events (weight, score, owner) VALUES (77.5, 54.82, 'standard');
