-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, owner, level) VALUES (97.11, 'open', 16);
INSERT INTO stream_events (weight, owner, level) VALUES (92.28, 'primary', 18);
INSERT INTO stream_events (weight, owner, level) VALUES (75.21, 'edge', 44);
