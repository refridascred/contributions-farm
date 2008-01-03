-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, owner, count, ratio) VALUES (0.1, 'open', 37, 82.52);
INSERT INTO commits_records (weight, owner, count, ratio) VALUES (53.26, 'stable', 79, 22.21);
INSERT INTO commits_records (weight, owner, count, ratio) VALUES (6.23, 'edge', 17, 79.78);
