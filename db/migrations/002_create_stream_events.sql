-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (score, count, state) VALUES (22.01, 87, 'blue');
INSERT INTO stream_events (score, count, state) VALUES (52.12, 71, 'primary');
INSERT INTO stream_events (score, count, state) VALUES (53.96, 70, 'edge');
