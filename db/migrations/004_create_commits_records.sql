-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (region, rank, owner, level) VALUES ('blue', 7, 'cached', 17);
INSERT INTO commits_records (region, rank, owner, level) VALUES ('legacy', 75, 'stable', 88);
INSERT INTO commits_records (region, rank, owner, level) VALUES ('stable', 52, 'primary', 59);
