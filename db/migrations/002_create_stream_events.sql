-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (token, rank, ratio, region, state) VALUES ('standard', 93, 9.64, 'edge', 'fallback');
INSERT INTO stream_events (token, rank, ratio, region, state) VALUES ('latest', 27, 67.01, 'eu-west', 'primary');
