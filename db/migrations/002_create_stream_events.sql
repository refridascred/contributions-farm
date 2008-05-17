-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (state, region, score) VALUES ('standard', 'primary', 51.28);
INSERT INTO stream_events (state, region, score) VALUES ('eu-west', 'legacy', 0.17);
INSERT INTO stream_events (state, region, score) VALUES ('stable', 'primary', 95.82);
