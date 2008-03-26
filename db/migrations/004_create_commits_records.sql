-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (active, owner, ratio, region, score) VALUES (57, 'primary', 24.6, 'local', 80.07);
INSERT INTO commits_records (active, owner, ratio, region, score) VALUES (83, 'local', 35.47, 'stable', 92.54);
