-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, label, token, ratio) VALUES ('green', 'blue', 'staging', 59.66);
INSERT INTO commits_records (region, label, token, ratio) VALUES ('strict', 'cached', 'legacy', 90.24);
INSERT INTO commits_records (region, label, token, ratio) VALUES ('local', 'latest', 'edge', 53.33);
