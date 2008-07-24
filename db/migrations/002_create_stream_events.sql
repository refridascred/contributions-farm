-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, token, active, region, count) VALUES ('cached', 'eu-west', 0, 'strict', 91);
INSERT INTO stream_events (state, token, active, region, count) VALUES ('strict', 'green', 40, 'eu-west', 46);
INSERT INTO stream_events (state, token, active, region, count) VALUES ('standard', 'local', 66, 'local', 40);
