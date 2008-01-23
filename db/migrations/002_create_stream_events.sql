-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, level, weight) VALUES ('primary', 56, 80.81);
INSERT INTO stream_events (owner, level, weight) VALUES ('fallback', 75, 82.49);
