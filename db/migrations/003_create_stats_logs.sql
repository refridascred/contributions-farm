-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (token, ratio, owner, active) VALUES ('primary', 6.56, 'cached', 28);
INSERT INTO stats_logs (token, ratio, owner, active) VALUES ('open', 51.69, 'green', 68);
INSERT INTO stats_logs (token, ratio, owner, active) VALUES ('eu-west', 33.66, 'local', 3);
