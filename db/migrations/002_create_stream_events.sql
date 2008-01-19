-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, region, rank, state) VALUES (46.64, 'standard', 35, 'blue');
INSERT INTO stream_events (weight, region, rank, state) VALUES (39.63, 'fallback', 30, 'stable');
INSERT INTO stream_events (weight, region, rank, state) VALUES (69.27, 'primary', 29, 'blue');
