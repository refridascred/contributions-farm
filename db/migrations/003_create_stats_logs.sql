-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, owner, token, active) VALUES ('blue', 'local', 'eu-west', 30);
INSERT INTO stats_logs (region, owner, token, active) VALUES ('cached', 'blue', 'green', 23);
INSERT INTO stats_logs (region, owner, token, active) VALUES ('legacy', 'local', 'standard', 76);
