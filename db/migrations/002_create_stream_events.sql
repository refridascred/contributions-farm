-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, count, label, region, state) VALUES (57.84, 48, 'standard', 'strict', 'open');
INSERT INTO stream_events (score, count, label, region, state) VALUES (85.23, 94, 'strict', 'fallback', 'open');
