-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (label, rank, level, active, weight) VALUES ('local', 44, 50, 35, 39.07);
INSERT INTO commits_records (label, rank, level, active, weight) VALUES ('green', 45, 11, 97, 83.22);
INSERT INTO commits_records (label, rank, level, active, weight) VALUES ('green', 14, 8, 63, 3.77);
