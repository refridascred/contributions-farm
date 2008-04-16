-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, weight, label, owner) VALUES (96.88, 32.96, 'standard', 'legacy');
INSERT INTO commits_records (score, weight, label, owner) VALUES (70.24, 93.75, 'local', 'open');
INSERT INTO commits_records (score, weight, label, owner) VALUES (17.71, 34.2, 'primary', 'cached');
