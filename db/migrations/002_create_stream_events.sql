-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, weight, owner) VALUES ('legacy', 37.17, 'green');
INSERT INTO stream_events (token, weight, owner) VALUES ('legacy', 38.57, 'blue');
