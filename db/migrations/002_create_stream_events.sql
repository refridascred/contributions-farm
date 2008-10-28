-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, state, ratio, score, weight) VALUES ('open', 'local', 0.24, 95.68, 75.2);
INSERT INTO stream_events (region, state, ratio, score, weight) VALUES ('strict', 'blue', 72.52, 55.01, 96.99);
