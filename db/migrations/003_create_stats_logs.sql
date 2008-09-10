-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (token, level, label, owner) VALUES ('open', 89, 'legacy', 'blue');
INSERT INTO stats_logs (token, level, label, owner) VALUES ('local', 93, 'local', 'legacy');
INSERT INTO stats_logs (token, level, label, owner) VALUES ('blue', 10, 'open', 'cached');
