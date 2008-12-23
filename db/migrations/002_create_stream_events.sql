-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, level, ratio, state) VALUES ('staging', 60, 37.38, 'open');
INSERT INTO stream_events (token, level, ratio, state) VALUES ('open', 81, 59.84, 'legacy');
