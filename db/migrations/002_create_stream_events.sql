-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, token, owner, state) VALUES (41.18, 'latest', 'local', 'primary');
INSERT INTO stream_events (weight, token, owner, state) VALUES (14.61, 'cached', 'latest', 'open');
INSERT INTO stream_events (weight, token, owner, state) VALUES (55.03, 'eu-west', 'eu-west', 'cached');
