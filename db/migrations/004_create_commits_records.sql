-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, score, ratio) VALUES (80, 50.47, 20.88);
INSERT INTO commits_records (active, score, ratio) VALUES (58, 15.12, 47.02);
INSERT INTO commits_records (active, score, ratio) VALUES (94, 1.24, 94.29);
