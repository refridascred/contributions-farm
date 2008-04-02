-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, count, label) VALUES ('blue', 44, 'cached');
INSERT INTO stream_events (region, count, label) VALUES ('local', 80, 'strict');
INSERT INTO stream_events (region, count, label) VALUES ('strict', 77, 'legacy');
