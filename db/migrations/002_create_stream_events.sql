-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, ratio, label, region) VALUES ('cached', 79.21, 'local', 'open');
INSERT INTO stream_events (state, ratio, label, region) VALUES ('green', 25.15, 'primary', 'staging');
