-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, weight, score, state) VALUES ('local', 33.5, 38.33, 'fallback');
INSERT INTO stream_events (region, weight, score, state) VALUES ('open', 35.61, 51.86, 'staging');
