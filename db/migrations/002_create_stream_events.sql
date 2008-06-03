-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (state, weight, label) VALUES ('staging', 72.2, 'open');
INSERT INTO stream_events (state, weight, label) VALUES ('eu-west', 56.47, 'open');
INSERT INTO stream_events (state, weight, label) VALUES ('staging', 47.99, 'eu-west');
