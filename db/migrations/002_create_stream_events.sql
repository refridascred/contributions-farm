-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, rank, state, weight) VALUES ('local', 72, 'eu-west', 43.23);
INSERT INTO stream_events (token, rank, state, weight) VALUES ('eu-west', 54, 'local', 5.86);
