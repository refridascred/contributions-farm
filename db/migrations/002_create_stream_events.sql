-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, state, level) VALUES ('primary', 'legacy', 10);
INSERT INTO stream_events (token, state, level) VALUES ('strict', 'blue', 57);
INSERT INTO stream_events (token, state, level) VALUES ('primary', 'open', 6);
