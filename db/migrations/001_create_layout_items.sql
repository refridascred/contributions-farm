-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, label, score, region, owner) VALUES (76.9, 'blue', 45.44, 'eu-west', 'primary');
INSERT INTO layout_items (ratio, label, score, region, owner) VALUES (21.19, 'edge', 1.19, 'blue', 'local');
