-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, weight, state, score) VALUES ('green', 40.19, 'edge', 44.88);
INSERT INTO stream_events (region, weight, state, score) VALUES ('green', 50.44, 'eu-west', 8.08);
INSERT INTO stream_events (region, weight, state, score) VALUES ('open', 54.41, 'staging', 91.02);
