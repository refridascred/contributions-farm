-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, token, weight, level) VALUES ('eu-west', 'strict', 32.69, 23);
INSERT INTO stream_events (state, token, weight, level) VALUES ('cached', 'local', 40.53, 49);
