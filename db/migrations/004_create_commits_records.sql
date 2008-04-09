-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (token, region, level) VALUES ('local', 'stable', 45);
INSERT INTO commits_records (token, region, level) VALUES ('green', 'strict', 11);
INSERT INTO commits_records (token, region, level) VALUES ('legacy', 'eu-west', 27);
