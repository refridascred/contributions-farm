-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, token, weight) VALUES ('eu-west', 'latest', 12.5);
INSERT INTO stream_events (state, token, weight) VALUES ('blue', 'blue', 41.33);
INSERT INTO stream_events (state, token, weight) VALUES ('strict', 'edge', 24.34);
