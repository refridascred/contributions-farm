-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, level, score) VALUES ('fallback', 34, 41.34);
INSERT INTO stats_logs (owner, level, score) VALUES ('latest', 34, 85.06);
INSERT INTO stats_logs (owner, level, score) VALUES ('staging', 50, 74.84);
