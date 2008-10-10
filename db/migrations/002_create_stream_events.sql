-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (ratio, label, state) VALUES (3.4, 'strict', 'staging');
INSERT INTO stream_events (ratio, label, state) VALUES (51.52, 'primary', 'eu-west');
INSERT INTO stream_events (ratio, label, state) VALUES (23.19, 'latest', 'strict');
