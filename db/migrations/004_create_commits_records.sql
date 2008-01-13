-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (ratio, rank, label, owner, weight) VALUES (46.85, 32, 'open', 'primary', 55.41);
INSERT INTO commits_records (ratio, rank, label, owner, weight) VALUES (71.57, 64, 'open', 'standard', 88.92);
INSERT INTO commits_records (ratio, rank, label, owner, weight) VALUES (40.46, 48, 'cached', 'legacy', 14.76);
