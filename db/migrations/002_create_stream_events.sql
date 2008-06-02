-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, active, region) VALUES ('legacy', 90, 'fallback');
INSERT INTO stream_events (label, active, region) VALUES ('edge', 41, 'primary');
INSERT INTO stream_events (label, active, region) VALUES ('staging', 27, 'cached');
