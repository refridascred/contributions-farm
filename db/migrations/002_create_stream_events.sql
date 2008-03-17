-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, rank, active) VALUES ('legacy', 69, 7);
INSERT INTO stream_events (label, rank, active) VALUES ('primary', 7, 40);
INSERT INTO stream_events (label, rank, active) VALUES ('open', 29, 91);
