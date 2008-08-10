-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, token, active) VALUES ('staging', 'strict', 77);
INSERT INTO stream_events (label, token, active) VALUES ('cached', 'latest', 27);
INSERT INTO stream_events (label, token, active) VALUES ('eu-west', 'legacy', 78);
