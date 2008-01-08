-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (label, weight, token, state) VALUES ('fallback', 41.2, 'green', 'latest');
INSERT INTO stream_events (label, weight, token, state) VALUES ('strict', 93.89, 'blue', 'eu-west');
INSERT INTO stream_events (label, weight, token, state) VALUES ('primary', 51.16, 'cached', 'staging');
