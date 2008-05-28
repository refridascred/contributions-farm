-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, label, active) VALUES (60.02, 'legacy', 3);
INSERT INTO commits_records (score, label, active) VALUES (29.83, 'blue', 49);
INSERT INTO commits_records (score, label, active) VALUES (13.47, 'latest', 11);
