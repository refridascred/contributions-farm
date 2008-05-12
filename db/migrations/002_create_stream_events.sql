-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, state, weight) VALUES ('legacy', 'standard', 90.96);
INSERT INTO stream_events (region, state, weight) VALUES ('blue', 'standard', 45.78);
INSERT INTO stream_events (region, state, weight) VALUES ('cached', 'green', 79.86);
