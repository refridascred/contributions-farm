-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, weight) VALUES ('cached', 33.6);
INSERT INTO stream_events (state, weight) VALUES ('green', 3.02);
INSERT INTO stream_events (state, weight) VALUES ('primary', 12.19);
