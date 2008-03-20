-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, owner, weight) VALUES ('standard', 'strict', 76.24);
INSERT INTO stream_events (token, owner, weight) VALUES ('green', 'legacy', 72.63);
INSERT INTO stream_events (token, owner, weight) VALUES ('legacy', 'primary', 76.2);
