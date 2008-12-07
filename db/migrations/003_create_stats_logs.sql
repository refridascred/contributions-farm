-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, token, rank, active, ratio) VALUES ('latest', 'staging', 61, 52, 33.84);
INSERT INTO stats_logs (owner, token, rank, active, ratio) VALUES ('edge', 'primary', 39, 62, 9.91);
