-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (label, active, count, ratio) VALUES ('cached', 30, 30, 21.57);
INSERT INTO stream_events (label, active, count, ratio) VALUES ('green', 2, 13, 57.12);
INSERT INTO stream_events (label, active, count, ratio) VALUES ('strict', 95, 18, 62.8);
