-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (label, level, weight, ratio) VALUES ('legacy', 79, 74.76, 35.49);
INSERT INTO commits_records (label, level, weight, ratio) VALUES ('strict', 62, 59.09, 47.73);
