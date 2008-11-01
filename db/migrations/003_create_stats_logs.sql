-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (region, owner, level, token, ratio) VALUES ('latest', 'staging', 43, 'latest', 54.22);
INSERT INTO stats_logs (region, owner, level, token, ratio) VALUES ('staging', 'legacy', 32, 'open', 47.79);
INSERT INTO stats_logs (region, owner, level, token, ratio) VALUES ('open', 'local', 32, 'stable', 69.65);
