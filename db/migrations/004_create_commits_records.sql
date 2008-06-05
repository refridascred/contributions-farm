-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (score, count, level) VALUES (36.94, 13, 90);
INSERT INTO commits_records (score, count, level) VALUES (0.53, 48, 63);
INSERT INTO commits_records (score, count, level) VALUES (96.68, 68, 46);
