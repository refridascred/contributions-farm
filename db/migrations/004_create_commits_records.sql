-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, owner, ratio, level, active) VALUES (53.8, 'primary', 35.91, 61, 49);
INSERT INTO commits_records (score, owner, ratio, level, active) VALUES (88.65, 'primary', 62.12, 94, 37);
INSERT INTO commits_records (score, owner, ratio, level, active) VALUES (52.83, 'standard', 4.46, 16, 92);
