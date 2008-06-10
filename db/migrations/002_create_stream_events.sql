-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, state, region, ratio) VALUES ('latest', 'strict', 'open', 96.58);
INSERT INTO stream_events (token, state, region, ratio) VALUES ('open', 'staging', 'blue', 26.85);
INSERT INTO stream_events (token, state, region, ratio) VALUES ('staging', 'stable', 'green', 91.16);
