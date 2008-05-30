-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (weight, state) VALUES (63.58, 'local');
INSERT INTO stream_events (weight, state) VALUES (95.23, 'staging');
INSERT INTO stream_events (weight, state) VALUES (65.07, 'primary');
