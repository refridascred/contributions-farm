-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, owner, weight) VALUES ('fallback', 'primary', 81.01);
INSERT INTO stream_events (token, owner, weight) VALUES ('local', 'primary', 95.02);
INSERT INTO stream_events (token, owner, weight) VALUES ('fallback', 'standard', 83.53);
