-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (label, rank, owner, ratio) VALUES ('staging', 22, 'stable', 5.04);
INSERT INTO commits_records (label, rank, owner, ratio) VALUES ('primary', 26, 'eu-west', 81.81);
INSERT INTO commits_records (label, rank, owner, ratio) VALUES ('latest', 31, 'local', 72.04);
