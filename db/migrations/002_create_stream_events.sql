-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (level, weight, owner) VALUES (65, 73.07, 'blue');
INSERT INTO stream_events (level, weight, owner) VALUES (23, 31.75, 'local');
INSERT INTO stream_events (level, weight, owner) VALUES (69, 34.04, 'staging');
