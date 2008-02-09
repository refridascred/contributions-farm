-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (token, label, ratio) VALUES ('primary', 'fallback', 1.73);
INSERT INTO commits_records (token, label, ratio) VALUES ('blue', 'strict', 48.12);
INSERT INTO commits_records (token, label, ratio) VALUES ('cached', 'cached', 62.76);
