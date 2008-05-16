-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, owner, weight, active) VALUES ('eu-west', 'cached', 6.24, 0);
INSERT INTO stream_events (token, owner, weight, active) VALUES ('latest', 'strict', 57.32, 49);
INSERT INTO stream_events (token, owner, weight, active) VALUES ('blue', 'staging', 90.77, 9);
