-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (level, weight, state) VALUES (94, 26.66, 'cached');
INSERT INTO stream_events (level, weight, state) VALUES (68, 21.36, 'stable');
INSERT INTO stream_events (level, weight, state) VALUES (51, 42.1, 'legacy');
