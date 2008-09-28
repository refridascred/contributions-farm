-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, state, ratio, score) VALUES ('legacy', 'cached', 36.65, 11.6);
INSERT INTO stream_events (token, state, ratio, score) VALUES ('staging', 'blue', 33.8, 8.06);
INSERT INTO stream_events (token, state, ratio, score) VALUES ('eu-west', 'latest', 66.74, 95.69);
