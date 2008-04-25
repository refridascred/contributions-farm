-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, ratio, owner, state) VALUES ('strict', 28.73, 'strict', 'legacy');
INSERT INTO stream_events (token, ratio, owner, state) VALUES ('latest', 50.86, 'green', 'edge');
INSERT INTO stream_events (token, ratio, owner, state) VALUES ('open', 70.98, 'eu-west', 'local');
