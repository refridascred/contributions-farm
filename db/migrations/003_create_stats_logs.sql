-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    label TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, ratio, label, rank, token) VALUES ('latest', 49.27, 'strict', 96, 'legacy');
INSERT INTO stats_logs (owner, ratio, label, rank, token) VALUES ('standard', 73.46, 'green', 27, 'blue');
