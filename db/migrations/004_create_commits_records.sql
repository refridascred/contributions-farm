-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    label TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, region, label, rank, weight) VALUES ('cached', 'cached', 'latest', 85, 47.44);
INSERT INTO commits_records (owner, region, label, rank, weight) VALUES ('stable', 'blue', 'blue', 1, 21.38);
INSERT INTO commits_records (owner, region, label, rank, weight) VALUES ('staging', 'local', 'primary', 52, 85.16);
