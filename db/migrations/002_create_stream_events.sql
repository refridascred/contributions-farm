-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, count, state) VALUES (38.38, 87, 'fallback');
INSERT INTO stream_events (weight, count, state) VALUES (81.11, 13, 'standard');
INSERT INTO stream_events (weight, count, state) VALUES (63.0, 35, 'cached');
