-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (state, region, ratio) VALUES ('blue', 'strict', 68.22);
INSERT INTO stream_events (state, region, ratio) VALUES ('edge', 'blue', 20.63);
INSERT INTO stream_events (state, region, ratio) VALUES ('latest', 'local', 27.48);
