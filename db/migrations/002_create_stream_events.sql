-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, label, token, owner, ratio) VALUES ('edge', 'edge', 'standard', 'fallback', 0.48);
INSERT INTO stream_events (region, label, token, owner, ratio) VALUES ('standard', 'blue', 'legacy', 'primary', 21.28);
INSERT INTO stream_events (region, label, token, owner, ratio) VALUES ('latest', 'strict', 'cached', 'staging', 11.61);
