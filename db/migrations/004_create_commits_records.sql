-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    level INTEGER,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (owner, weight, level, rank, active) VALUES ('latest', 80.51, 39, 32, 56);
INSERT INTO commits_records (owner, weight, level, rank, active) VALUES ('stable', 59.89, 47, 34, 35);
