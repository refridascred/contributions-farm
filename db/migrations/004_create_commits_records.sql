-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (region, label, rank, owner) VALUES ('strict', 'stable', 52, 'primary');
INSERT INTO commits_records (region, label, rank, owner) VALUES ('latest', 'standard', 98, 'open');
