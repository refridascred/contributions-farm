-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, level, region, rank) VALUES ('fallback', 81, 'eu-west', 54);
INSERT INTO commits_records (token, level, region, rank) VALUES ('staging', 26, 'strict', 2);
INSERT INTO commits_records (token, level, region, rank) VALUES ('fallback', 93, 'green', 66);
