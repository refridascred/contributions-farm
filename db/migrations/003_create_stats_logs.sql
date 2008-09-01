-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, level, owner) VALUES ('blue', 56, 'staging');
INSERT INTO stats_logs (token, level, owner) VALUES ('stable', 97, 'local');
INSERT INTO stats_logs (token, level, owner) VALUES ('staging', 73, 'standard');
