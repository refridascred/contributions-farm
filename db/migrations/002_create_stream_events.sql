-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (level, token, active, weight) VALUES (46, 'latest', 61, 55.01);
INSERT INTO stream_events (level, token, active, weight) VALUES (45, 'primary', 76, 71.09);
INSERT INTO stream_events (level, token, active, weight) VALUES (65, 'local', 52, 38.24);
