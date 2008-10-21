-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (level, ratio, owner, region, score) VALUES (64, 52.09, 'staging', 'eu-west', 35.63);
INSERT INTO layout_items (level, ratio, owner, region, score) VALUES (25, 17.36, 'blue', 'stable', 86.19);
