-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, token, active, ratio) VALUES ('cached', 'eu-west', 40, 78.13);
INSERT INTO stream_events (state, token, active, ratio) VALUES ('open', 'green', 47, 75.57);
INSERT INTO stream_events (state, token, active, ratio) VALUES ('legacy', 'green', 41, 10.99);
