-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, rank, weight, owner, level) VALUES (16, 23, 7.33, 'primary', 54);
INSERT INTO commits_records (active, rank, weight, owner, level) VALUES (30, 19, 70.58, 'stable', 4);
