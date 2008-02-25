-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, ratio) VALUES ('eu-west', 90.7);
INSERT INTO stream_events (label, ratio) VALUES ('cached', 40.42);
INSERT INTO stream_events (label, ratio) VALUES ('blue', 41.66);
