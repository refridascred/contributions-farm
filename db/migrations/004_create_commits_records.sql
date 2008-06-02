-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    rank INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (region, level, rank, owner, score) VALUES ('green', 34, 92, 'latest', 39.22);
INSERT INTO commits_records (region, level, rank, owner, score) VALUES ('green', 9, 19, 'primary', 13.92);
INSERT INTO commits_records (region, level, rank, owner, score) VALUES ('legacy', 69, 4, 'latest', 93.4);
