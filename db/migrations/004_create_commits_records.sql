-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (label, token, region, owner, ratio) VALUES ('legacy', 'open', 'eu-west', 'stable', 3.94);
INSERT INTO commits_records (label, token, region, owner, ratio) VALUES ('local', 'standard', 'primary', 'primary', 43.12);
INSERT INTO commits_records (label, token, region, owner, ratio) VALUES ('primary', 'strict', 'green', 'legacy', 51.18);
