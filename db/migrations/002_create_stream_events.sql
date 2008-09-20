-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, ratio, score) VALUES ('local', 32.11, 83.61);
INSERT INTO stream_events (state, ratio, score) VALUES ('primary', 83.63, 17.14);
INSERT INTO stream_events (state, ratio, score) VALUES ('strict', 74.53, 41.49);
