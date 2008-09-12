-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, level, token, ratio) VALUES ('strict', 18, 'primary', 54.92);
INSERT INTO commits_records (label, level, token, ratio) VALUES ('legacy', 61, 'green', 22.02);
INSERT INTO commits_records (label, level, token, ratio) VALUES ('staging', 6, 'legacy', 86.47);
