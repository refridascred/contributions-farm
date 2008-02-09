-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (region, owner, active) VALUES ('blue', 'eu-west', 26);
INSERT INTO stats_logs (region, owner, active) VALUES ('latest', 'strict', 37);
INSERT INTO stats_logs (region, owner, active) VALUES ('fallback', 'local', 60);
