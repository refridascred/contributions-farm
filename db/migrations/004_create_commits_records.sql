-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, owner, active, ratio, weight) VALUES (34.89, 'edge', 12, 58.47, 36.64);
INSERT INTO commits_records (score, owner, active, ratio, weight) VALUES (9.04, 'legacy', 6, 24.58, 18.1);
INSERT INTO commits_records (score, owner, active, ratio, weight) VALUES (77.26, 'standard', 46, 97.74, 93.74);
