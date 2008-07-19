-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (region, score, weight, level, ratio) VALUES ('strict', 11.55, 87.29, 67, 84.94);
INSERT INTO layout_items (region, score, weight, level, ratio) VALUES ('legacy', 69.96, 69.72, 85, 98.49);
