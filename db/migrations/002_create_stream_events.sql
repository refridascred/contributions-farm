-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, level, weight) VALUES (59, 47, 87.33);
INSERT INTO stream_events (active, level, weight) VALUES (49, 37, 10.27);
INSERT INTO stream_events (active, level, weight) VALUES (10, 38, 48.74);
