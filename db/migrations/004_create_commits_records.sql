-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (active, score, ratio) VALUES (79, 18.83, 62.8);
INSERT INTO commits_records (active, score, ratio) VALUES (56, 79.8, 44.29);
INSERT INTO commits_records (active, score, ratio) VALUES (73, 35.71, 42.01);
