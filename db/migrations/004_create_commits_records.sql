-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, level, owner, label) VALUES (90, 49, 'stable', 'open');
INSERT INTO commits_records (rank, level, owner, label) VALUES (56, 28, 'local', 'standard');
