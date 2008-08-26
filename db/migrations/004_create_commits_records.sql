-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, active, score, region, ratio) VALUES ('staging', 26, 39.63, 'blue', 12.05);
INSERT INTO commits_records (owner, active, score, region, ratio) VALUES ('strict', 51, 23.1, 'cached', 11.78);
INSERT INTO commits_records (owner, active, score, region, ratio) VALUES ('cached', 86, 4.58, 'green', 10.23);
