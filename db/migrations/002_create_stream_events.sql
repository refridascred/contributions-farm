-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, ratio, state) VALUES ('staging', 87.31, 'open');
INSERT INTO stream_events (token, ratio, state) VALUES ('strict', 40.17, 'latest');
INSERT INTO stream_events (token, ratio, state) VALUES ('stable', 72.84, 'local');
