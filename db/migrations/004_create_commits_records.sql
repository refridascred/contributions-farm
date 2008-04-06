-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (label, level, region) VALUES ('eu-west', 97, 'blue');
INSERT INTO commits_records (label, level, region) VALUES ('local', 44, 'blue');
INSERT INTO commits_records (label, level, region) VALUES ('legacy', 83, 'staging');
