-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, ratio, label) VALUES ('latest', 10.92, 'latest');
INSERT INTO stream_events (state, ratio, label) VALUES ('standard', 90.49, 'latest');
