-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (ratio, weight, state) VALUES (59.47, 50.24, 'eu-west');
INSERT INTO stream_events (ratio, weight, state) VALUES (29.89, 54.64, 'primary');
