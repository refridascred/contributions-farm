-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (label, owner, level, score, weight) VALUES ('eu-west', 'legacy', 96, 56.2, 64.98);
INSERT INTO commits_records (label, owner, level, score, weight) VALUES ('fallback', 'green', 95, 23.05, 51.32);
INSERT INTO commits_records (label, owner, level, score, weight) VALUES ('latest', 'standard', 69, 6.58, 85.43);
