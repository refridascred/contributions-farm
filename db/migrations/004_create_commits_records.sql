-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, region, rank, owner, ratio) VALUES (57, 'cached', 39, 'strict', 49.97);
INSERT INTO commits_records (count, region, rank, owner, ratio) VALUES (91, 'green', 51, 'local', 31.46);
INSERT INTO commits_records (count, region, rank, owner, ratio) VALUES (75, 'fallback', 19, 'edge', 88.0);
