-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (region, weight, score, owner, ratio) VALUES ('primary', 65.77, 83.91, 'local', 61.95);
INSERT INTO commits_records (region, weight, score, owner, ratio) VALUES ('local', 61.66, 22.15, 'local', 80.71);
