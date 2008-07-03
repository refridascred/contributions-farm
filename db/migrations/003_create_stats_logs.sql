-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, label, token, level) VALUES ('standard', 'green', 'local', 33);
INSERT INTO stats_logs (owner, label, token, level) VALUES ('stable', 'stable', 'standard', 41);
INSERT INTO stats_logs (owner, label, token, level) VALUES ('stable', 'legacy', 'eu-west', 55);
