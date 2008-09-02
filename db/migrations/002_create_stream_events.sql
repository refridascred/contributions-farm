-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, weight, region, state) VALUES ('standard', 0.43, 'open', 'open');
INSERT INTO stream_events (label, weight, region, state) VALUES ('cached', 71.15, 'fallback', 'strict');
INSERT INTO stream_events (label, weight, region, state) VALUES ('eu-west', 94.62, 'primary', 'legacy');
