-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, score, ratio, state) VALUES ('fallback', 45.46, 60.23, 'cached');
INSERT INTO stream_events (token, score, ratio, state) VALUES ('staging', 33.61, 12.74, 'local');
INSERT INTO stream_events (token, score, ratio, state) VALUES ('edge', 41.16, 2.3, 'latest');
