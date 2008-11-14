-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (weight, ratio, owner, level) VALUES (95.72, 62.5, 'standard', 79);
INSERT INTO commits_records (weight, ratio, owner, level) VALUES (25.78, 11.28, 'strict', 62);
INSERT INTO commits_records (weight, ratio, owner, level) VALUES (84.05, 19.7, 'eu-west', 74);
