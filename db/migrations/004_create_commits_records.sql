-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (region, rank, token) VALUES ('cached', 65, 'cached');
INSERT INTO commits_records (region, rank, token) VALUES ('cached', 64, 'legacy');
INSERT INTO commits_records (region, rank, token) VALUES ('primary', 94, 'local');
