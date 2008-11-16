-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, active, level, rank, label) VALUES (78.51, 68, 99, 96, 'open');
INSERT INTO commits_records (score, active, level, rank, label) VALUES (3.92, 71, 57, 66, 'cached');
INSERT INTO commits_records (score, active, level, rank, label) VALUES (36.32, 19, 77, 5, 'stable');
