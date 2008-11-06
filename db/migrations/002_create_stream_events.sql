-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, label, weight) VALUES ('eu-west', 'eu-west', 22.89);
INSERT INTO stream_events (owner, label, weight) VALUES ('eu-west', 'strict', 78.36);
