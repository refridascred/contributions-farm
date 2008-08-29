-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, ratio, state) VALUES ('primary', 69.19, 'eu-west');
INSERT INTO stream_events (label, ratio, state) VALUES ('fallback', 26.7, 'strict');
INSERT INTO stream_events (label, ratio, state) VALUES ('local', 5.63, 'legacy');
