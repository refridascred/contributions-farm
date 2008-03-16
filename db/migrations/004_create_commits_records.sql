-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (owner, count, label, score, weight) VALUES ('stable', 80, 'strict', 35.91, 2.39);
INSERT INTO commits_records (owner, count, label, score, weight) VALUES ('edge', 5, 'cached', 32.47, 13.11);
INSERT INTO commits_records (owner, count, label, score, weight) VALUES ('cached', 36, 'primary', 91.51, 38.42);
