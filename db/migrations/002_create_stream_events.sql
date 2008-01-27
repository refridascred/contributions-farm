-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, count, owner) VALUES ('strict', 7, 'green');
INSERT INTO stream_events (label, count, owner) VALUES ('local', 30, 'primary');
INSERT INTO stream_events (label, count, owner) VALUES ('local', 59, 'green');
