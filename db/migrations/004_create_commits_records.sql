-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, active, label, ratio) VALUES (41.66, 70, 'open', 14.5);
INSERT INTO commits_records (score, active, label, ratio) VALUES (21.05, 14, 'local', 45.04);
INSERT INTO commits_records (score, active, label, ratio) VALUES (94.31, 17, 'latest', 53.94);
