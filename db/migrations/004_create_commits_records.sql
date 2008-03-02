-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (token, region, weight) VALUES ('eu-west', 'staging', 59.9);
INSERT INTO commits_records (token, region, weight) VALUES ('staging', 'blue', 55.52);
INSERT INTO commits_records (token, region, weight) VALUES ('open', 'stable', 37.2);
