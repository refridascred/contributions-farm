-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, state, score) VALUES ('cached', 'stable', 2.17);
INSERT INTO stream_events (region, state, score) VALUES ('cached', 'green', 61.78);
INSERT INTO stream_events (region, state, score) VALUES ('standard', 'latest', 87.09);
