-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, ratio, score, region) VALUES ('fallback', 85.45, 46.55, 'cached');
INSERT INTO layout_items (owner, ratio, score, region) VALUES ('eu-west', 60.69, 67.77, 'primary');
INSERT INTO layout_items (owner, ratio, score, region) VALUES ('stable', 47.91, 97.57, 'eu-west');
