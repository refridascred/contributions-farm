-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (token, active) VALUES ('latest', 87);
INSERT INTO stats_logs (token, active) VALUES ('eu-west', 53);
INSERT INTO stats_logs (token, active) VALUES ('standard', 29);
