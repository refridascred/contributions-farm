-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (state, weight, owner, level) VALUES ('standard', 63.65, 'open', 62);
INSERT INTO stream_events (state, weight, owner, level) VALUES ('eu-west', 35.25, 'fallback', 47);
