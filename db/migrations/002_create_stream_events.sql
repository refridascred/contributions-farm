-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    rank INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (state, label, rank, ratio, region) VALUES ('eu-west', 'cached', 40, 3.52, 'legacy');
INSERT INTO stream_events (state, label, rank, ratio, region) VALUES ('green', 'blue', 95, 90.57, 'staging');
