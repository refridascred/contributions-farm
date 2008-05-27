-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, score, owner, ratio, rank) VALUES (21.67, 6.54, 'eu-west', 57.06, 95);
INSERT INTO commits_records (weight, score, owner, ratio, rank) VALUES (11.04, 13.31, 'local', 59.41, 15);
