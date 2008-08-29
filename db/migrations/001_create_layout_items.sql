-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, score, token, label, region) VALUES (52.88, 2.47, 'cached', 'eu-west', 'local');
INSERT INTO layout_items (ratio, score, token, label, region) VALUES (5.89, 52.24, 'primary', 'stable', 'eu-west');
INSERT INTO layout_items (ratio, score, token, label, region) VALUES (66.35, 97.54, 'latest', 'primary', 'stable');
