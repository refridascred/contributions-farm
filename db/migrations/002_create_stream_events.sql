-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, ratio) VALUES ('blue', 76.85);
INSERT INTO stream_events (label, ratio) VALUES ('local', 27.52);
INSERT INTO stream_events (label, ratio) VALUES ('blue', 59.75);
