-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, token, active) VALUES ('staging', 'strict', 1);
INSERT INTO stats_logs (region, token, active) VALUES ('green', 'strict', 76);
INSERT INTO stats_logs (region, token, active) VALUES ('strict', 'legacy', 56);
