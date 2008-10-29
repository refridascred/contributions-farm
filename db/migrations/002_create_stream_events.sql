-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, ratio, level, state, label) VALUES (49.37, 55.37, 45, 'primary', 'standard');
INSERT INTO stream_events (weight, ratio, level, state, label) VALUES (83.99, 40.59, 38, 'latest', 'latest');
INSERT INTO stream_events (weight, ratio, level, state, label) VALUES (13.16, 31.81, 46, 'latest', 'blue');
