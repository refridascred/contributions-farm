-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, region, score, rank, level) VALUES ('open', 'staging', 66.33, 13, 97);
INSERT INTO commits_records (owner, region, score, rank, level) VALUES ('strict', 'standard', 44.06, 0, 13);
