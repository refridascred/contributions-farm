-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, label, rank) VALUES ('primary', 'standard', 67);
INSERT INTO stream_events (token, label, rank) VALUES ('staging', 'strict', 87);
INSERT INTO stream_events (token, label, rank) VALUES ('primary', 'edge', 41);
