-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, region, level, active, rank) VALUES ('eu-west', 'legacy', 99, 45, 72);
INSERT INTO commits_records (owner, region, level, active, rank) VALUES ('eu-west', 'strict', 86, 61, 0);
