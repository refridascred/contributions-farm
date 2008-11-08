-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, level, region, count) VALUES ('local', 82, 'local', 56);
INSERT INTO stream_events (label, level, region, count) VALUES ('staging', 54, 'legacy', 63);
INSERT INTO stream_events (label, level, region, count) VALUES ('legacy', 44, 'legacy', 65);
