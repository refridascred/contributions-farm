-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (score, rank, level) VALUES (89.16, 76, 93);
INSERT INTO commits_records (score, rank, level) VALUES (6.27, 44, 73);
INSERT INTO commits_records (score, rank, level) VALUES (81.98, 34, 57);
