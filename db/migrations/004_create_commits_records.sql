-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, region, level, ratio) VALUES ('local', 'primary', 13, 26.05);
INSERT INTO commits_records (label, region, level, ratio) VALUES ('local', 'legacy', 84, 81.6);
INSERT INTO commits_records (label, region, level, ratio) VALUES ('strict', 'standard', 53, 60.39);
