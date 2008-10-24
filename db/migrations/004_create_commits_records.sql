-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (region, rank, label, ratio) VALUES ('green', 4, 'open', 72.81);
INSERT INTO commits_records (region, rank, label, ratio) VALUES ('blue', 9, 'primary', 10.46);
INSERT INTO commits_records (region, rank, label, ratio) VALUES ('local', 82, 'cached', 53.88);
