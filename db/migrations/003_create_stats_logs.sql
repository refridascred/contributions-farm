-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, token, level) VALUES ('blue', 'latest', 12);
INSERT INTO stats_logs (owner, token, level) VALUES ('latest', 'legacy', 85);
INSERT INTO stats_logs (owner, token, level) VALUES ('cached', 'primary', 46);
