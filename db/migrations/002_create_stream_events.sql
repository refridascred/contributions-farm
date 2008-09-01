-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, weight, state, count, ratio) VALUES (54, 53.76, 'local', 0, 87.39);
INSERT INTO stream_events (active, weight, state, count, ratio) VALUES (43, 31.9, 'blue', 43, 83.44);
