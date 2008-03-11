-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (token, active, owner) VALUES ('open', 3, 'primary');
INSERT INTO stats_logs (token, active, owner) VALUES ('eu-west', 62, 'cached');
INSERT INTO stats_logs (token, active, owner) VALUES ('open', 90, 'latest');
