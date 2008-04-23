-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, label, region, active) VALUES ('cached', 'staging', 'green', 97);
INSERT INTO stream_events (state, label, region, active) VALUES ('edge', 'eu-west', 'open', 67);
INSERT INTO stream_events (state, label, region, active) VALUES ('eu-west', 'cached', 'local', 91);
