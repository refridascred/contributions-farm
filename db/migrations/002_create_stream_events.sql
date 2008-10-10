-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, level, weight) VALUES ('blue', 34, 83.51);
INSERT INTO stream_events (state, level, weight) VALUES ('eu-west', 30, 9.19);
INSERT INTO stream_events (state, level, weight) VALUES ('cached', 10, 14.29);
