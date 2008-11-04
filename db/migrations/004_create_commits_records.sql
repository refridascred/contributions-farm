-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (region, label, level) VALUES ('blue', 'latest', 77);
INSERT INTO commits_records (region, label, level) VALUES ('open', 'legacy', 64);
INSERT INTO commits_records (region, label, level) VALUES ('strict', 'staging', 51);
