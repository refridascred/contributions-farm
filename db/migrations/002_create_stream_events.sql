-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, label, weight) VALUES ('strict', 'legacy', 77.23);
INSERT INTO stream_events (state, label, weight) VALUES ('cached', 'standard', 11.83);
INSERT INTO stream_events (state, label, weight) VALUES ('green', 'strict', 21.87);
