-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, active, label, score) VALUES ('legacy', 29, 'cached', 14.21);
INSERT INTO stream_events (region, active, label, score) VALUES ('strict', 35, 'edge', 46.64);
INSERT INTO stream_events (region, active, label, score) VALUES ('staging', 0, 'green', 85.87);
