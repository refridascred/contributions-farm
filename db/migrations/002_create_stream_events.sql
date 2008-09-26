-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, state, ratio) VALUES (95.97, 'standard', 21.31);
INSERT INTO stream_events (weight, state, ratio) VALUES (40.1, 'legacy', 64.1);
