-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, score, label, ratio) VALUES ('green', 4.64, 'edge', 29.99);
INSERT INTO commits_records (region, score, label, ratio) VALUES ('eu-west', 84.08, 'open', 63.28);
INSERT INTO commits_records (region, score, label, ratio) VALUES ('green', 2.8, 'edge', 38.68);
