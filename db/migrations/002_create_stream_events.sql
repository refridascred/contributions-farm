-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, token, owner) VALUES ('standard', 'strict', 'fallback');
INSERT INTO stream_events (region, token, owner) VALUES ('legacy', 'blue', 'legacy');
