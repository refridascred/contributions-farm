-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (state, weight, region, rank) VALUES ('green', 85.66, 'fallback', 77);
INSERT INTO stream_events (state, weight, region, rank) VALUES ('local', 92.77, 'legacy', 4);
INSERT INTO stream_events (state, weight, region, rank) VALUES ('local', 65.84, 'local', 28);
