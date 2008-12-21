-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (active, ratio, state) VALUES (93, 61.33, 'staging');
INSERT INTO stream_events (active, ratio, state) VALUES (52, 54.1, 'staging');
INSERT INTO stream_events (active, ratio, state) VALUES (21, 82.19, 'eu-west');
