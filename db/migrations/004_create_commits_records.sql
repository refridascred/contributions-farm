-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, score, count) VALUES ('local', 66.88, 12);
INSERT INTO commits_records (region, score, count) VALUES ('local', 50.77, 70);
INSERT INTO commits_records (region, score, count) VALUES ('staging', 76.64, 7);
