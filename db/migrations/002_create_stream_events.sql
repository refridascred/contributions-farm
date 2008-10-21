-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, region, ratio, score) VALUES ('edge', 'open', 49.89, 98.11);
INSERT INTO stream_events (state, region, ratio, score) VALUES ('cached', 'fallback', 36.05, 30.76);
INSERT INTO stream_events (state, region, ratio, score) VALUES ('eu-west', 'latest', 76.39, 30.87);
