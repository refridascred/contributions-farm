-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (level, label, ratio) VALUES (0, 'blue', 0.79);
INSERT INTO commits_records (level, label, ratio) VALUES (97, 'staging', 56.34);
INSERT INTO commits_records (level, label, ratio) VALUES (37, 'open', 7.82);
