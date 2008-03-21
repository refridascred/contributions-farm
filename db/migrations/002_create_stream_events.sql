-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (state, ratio, level, weight) VALUES ('green', 56.54, 16, 93.57);
INSERT INTO stream_events (state, ratio, level, weight) VALUES ('stable', 67.53, 44, 79.59);
INSERT INTO stream_events (state, ratio, level, weight) VALUES ('green', 48.2, 17, 71.79);
