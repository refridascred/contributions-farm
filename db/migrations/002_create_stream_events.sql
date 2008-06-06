-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, active, rank, token) VALUES ('eu-west', 0, 18, 'blue');
INSERT INTO stream_events (label, active, rank, token) VALUES ('latest', 33, 40, 'edge');
