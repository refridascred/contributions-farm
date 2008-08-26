-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (region, label, ratio) VALUES ('legacy', 'primary', 89.7);
INSERT INTO stream_events (region, label, ratio) VALUES ('staging', 'strict', 80.94);
