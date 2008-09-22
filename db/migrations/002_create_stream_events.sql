-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, state, weight) VALUES ('latest', 'open', 25.75);
INSERT INTO stream_events (token, state, weight) VALUES ('cached', 'fallback', 97.04);
INSERT INTO stream_events (token, state, weight) VALUES ('strict', 'stable', 37.68);
