-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    label TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (ratio, rank, label, token, level) VALUES (20.52, 79, 'edge', 'strict', 38);
INSERT INTO commits_records (ratio, rank, label, token, level) VALUES (32.43, 91, 'green', 'local', 69);
INSERT INTO commits_records (ratio, rank, label, token, level) VALUES (19.59, 57, 'standard', 'stable', 92);
