-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, state, token, ratio, level) VALUES ('latest', 'local', 'edge', 61.1, 60);
INSERT INTO stream_events (label, state, token, ratio, level) VALUES ('open', 'standard', 'cached', 13.16, 81);
