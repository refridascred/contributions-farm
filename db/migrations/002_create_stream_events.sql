-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (rank, label, region, ratio, state) VALUES (98, 'latest', 'standard', 83.35, 'fallback');
INSERT INTO stream_events (rank, label, region, ratio, state) VALUES (12, 'latest', 'legacy', 53.37, 'local');
