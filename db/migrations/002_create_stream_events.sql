-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, owner, weight, state) VALUES ('open', 'standard', 67.03, 'edge');
INSERT INTO stream_events (region, owner, weight, state) VALUES ('edge', 'cached', 88.49, 'local');
INSERT INTO stream_events (region, owner, weight, state) VALUES ('edge', 'primary', 82.86, 'latest');
