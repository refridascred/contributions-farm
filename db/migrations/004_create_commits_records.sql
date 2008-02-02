-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (token, region, weight) VALUES ('standard', 'fallback', 63.83);
INSERT INTO commits_records (token, region, weight) VALUES ('primary', 'strict', 44.8);
INSERT INTO commits_records (token, region, weight) VALUES ('local', 'standard', 30.12);
