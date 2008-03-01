-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, rank, score, label) VALUES (70, 83, 49.65, 'cached');
INSERT INTO commits_records (level, rank, score, label) VALUES (66, 57, 32.75, 'latest');
INSERT INTO commits_records (level, rank, score, label) VALUES (79, 6, 5.08, 'green');
