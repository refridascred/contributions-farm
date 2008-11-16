-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, ratio) VALUES ('eu-west', 45.65);
INSERT INTO stream_events (state, ratio) VALUES ('stable', 77.38);
INSERT INTO stream_events (state, ratio) VALUES ('open', 4.57);
