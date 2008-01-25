-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    token TEXT,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, label, token, ratio, region) VALUES ('latest', 'latest', 'latest', 94.62, 'primary');
INSERT INTO stream_events (state, label, token, ratio, region) VALUES ('primary', 'latest', 'green', 39.67, 'strict');
INSERT INTO stream_events (state, label, token, ratio, region) VALUES ('latest', 'blue', 'legacy', 3.15, 'stable');
