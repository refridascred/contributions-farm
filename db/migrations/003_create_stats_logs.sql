-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (label, token, active, rank) VALUES ('staging', 'fallback', 70, 62);
INSERT INTO stats_logs (label, token, active, rank) VALUES ('standard', 'eu-west', 54, 95);
