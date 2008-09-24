-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (count, weight, state, level) VALUES (85, 50.86, 'standard', 65);
INSERT INTO stream_events (count, weight, state, level) VALUES (92, 36.52, 'stable', 19);
INSERT INTO stream_events (count, weight, state, level) VALUES (21, 86.2, 'stable', 2);
