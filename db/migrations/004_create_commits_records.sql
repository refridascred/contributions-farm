-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, region, token, ratio) VALUES (20, 'standard', 'eu-west', 14.73);
INSERT INTO commits_records (level, region, token, ratio) VALUES (19, 'blue', 'edge', 4.44);
