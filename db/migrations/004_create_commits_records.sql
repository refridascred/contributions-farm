-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, rank, count, ratio, weight) VALUES ('cached', 31, 40, 23.55, 6.2);
INSERT INTO commits_records (owner, rank, count, ratio, weight) VALUES ('local', 41, 55, 81.3, 1.53);
INSERT INTO commits_records (owner, rank, count, ratio, weight) VALUES ('open', 39, 85, 62.24, 64.34);
