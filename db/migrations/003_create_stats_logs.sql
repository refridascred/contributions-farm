-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (token, active, owner, weight, rank) VALUES ('eu-west', 62, 'local', 81.88, 25);
INSERT INTO stats_logs (token, active, owner, weight, rank) VALUES ('stable', 87, 'blue', 38.93, 51);
