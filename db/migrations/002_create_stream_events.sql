-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, state, ratio, level) VALUES ('stable', 'strict', 83.41, 37);
INSERT INTO stream_events (token, state, ratio, level) VALUES ('primary', 'latest', 45.22, 40);
INSERT INTO stream_events (token, state, ratio, level) VALUES ('eu-west', 'eu-west', 42.16, 60);
