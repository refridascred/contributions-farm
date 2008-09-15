-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, region, ratio) VALUES ('standard', 'fallback', 15.86);
INSERT INTO commits_records (owner, region, ratio) VALUES ('staging', 'edge', 38.45);
INSERT INTO commits_records (owner, region, ratio) VALUES ('stable', 'eu-west', 40.09);
