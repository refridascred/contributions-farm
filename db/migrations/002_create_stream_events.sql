-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (ratio, state, label, level) VALUES (46.61, 'cached', 'staging', 34);
INSERT INTO stream_events (ratio, state, label, level) VALUES (58.57, 'primary', 'cached', 23);
INSERT INTO stream_events (ratio, state, label, level) VALUES (4.75, 'latest', 'latest', 99);
