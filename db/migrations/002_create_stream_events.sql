-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, token, level, region) VALUES ('open', 'primary', 59, 'eu-west');
INSERT INTO stream_events (state, token, level, region) VALUES ('green', 'blue', 65, 'stable');
INSERT INTO stream_events (state, token, level, region) VALUES ('cached', 'stable', 95, 'local');
