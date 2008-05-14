-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, ratio, rank, owner, weight) VALUES (20.87, 55.09, 50, 'stable', 57.22);
INSERT INTO commits_records (score, ratio, rank, owner, weight) VALUES (28.94, 32.03, 62, 'stable', 0.32);
INSERT INTO commits_records (score, ratio, rank, owner, weight) VALUES (89.4, 19.42, 19, 'local', 71.66);
