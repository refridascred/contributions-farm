-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, state, active, label) VALUES ('cached', 'edge', 11, 'edge');
INSERT INTO stream_events (region, state, active, label) VALUES ('legacy', 'green', 35, 'eu-west');
