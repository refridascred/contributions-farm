-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, ratio, label) VALUES ('latest', 4.37, 'eu-west');
INSERT INTO stream_events (state, ratio, label) VALUES ('standard', 63.16, 'open');
INSERT INTO stream_events (state, ratio, label) VALUES ('blue', 19.41, 'legacy');
