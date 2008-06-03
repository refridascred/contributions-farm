-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (region, level, owner, rank, count) VALUES ('local', 24, 'primary', 6, 79);
INSERT INTO commits_records (region, level, owner, rank, count) VALUES ('legacy', 64, 'primary', 92, 53);
