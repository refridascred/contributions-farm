-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, active, score, count, weight) VALUES ('legacy', 71, 98.24, 68, 1.23);
INSERT INTO commits_records (region, active, score, count, weight) VALUES ('eu-west', 54, 75.02, 76, 72.82);
