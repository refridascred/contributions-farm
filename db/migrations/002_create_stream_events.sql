-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, token, owner, level) VALUES ('green', 'eu-west', 'latest', 48);
INSERT INTO stream_events (state, token, owner, level) VALUES ('latest', 'latest', 'latest', 75);
