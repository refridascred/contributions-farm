-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, level, token, ratio) VALUES ('blue', 29, 'open', 17.37);
INSERT INTO commits_records (region, level, token, ratio) VALUES ('local', 97, 'primary', 58.51);
INSERT INTO commits_records (region, level, token, ratio) VALUES ('blue', 53, 'strict', 43.16);
