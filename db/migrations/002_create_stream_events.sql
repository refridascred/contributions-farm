-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, owner, level, count) VALUES ('latest', 'local', 99, 44);
INSERT INTO stream_events (state, owner, level, count) VALUES ('standard', 'eu-west', 61, 40);
INSERT INTO stream_events (state, owner, level, count) VALUES ('standard', 'strict', 51, 37);
