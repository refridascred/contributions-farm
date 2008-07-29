-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, state, ratio, label, score) VALUES ('eu-west', 'strict', 27.47, 'strict', 17.53);
INSERT INTO stream_events (region, state, ratio, label, score) VALUES ('strict', 'staging', 60.1, 'edge', 12.67);
INSERT INTO stream_events (region, state, ratio, label, score) VALUES ('open', 'standard', 17.08, 'standard', 55.52);
