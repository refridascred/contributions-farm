-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, token, level, score) VALUES ('legacy', 'legacy', 36, 76.89);
INSERT INTO stats_logs (owner, token, level, score) VALUES ('strict', 'blue', 52, 89.67);
INSERT INTO stats_logs (owner, token, level, score) VALUES ('staging', 'local', 69, 50.49);
