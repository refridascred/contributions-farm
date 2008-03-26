-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, count) VALUES ('cached', 69);
INSERT INTO stream_events (label, count) VALUES ('strict', 58);
INSERT INTO stream_events (label, count) VALUES ('cached', 28);
