-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, score, region, ratio) VALUES (41.47, 60.34, 'eu-west', 94.4);
INSERT INTO layout_items (weight, score, region, ratio) VALUES (96.44, 56.02, 'green', 14.29);
INSERT INTO layout_items (weight, score, region, ratio) VALUES (89.69, 12.45, 'blue', 69.5);
