-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, token, region, level, ratio) VALUES ('green', 'primary', 'strict', 85, 23.41);
INSERT INTO commits_records (label, token, region, level, ratio) VALUES ('cached', 'primary', 'latest', 31, 44.0);
INSERT INTO commits_records (label, token, region, level, ratio) VALUES ('eu-west', 'green', 'primary', 20, 75.23);
