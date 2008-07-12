-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (ratio, owner, count, weight, region) VALUES (96.5, 'green', 68, 46.31, 'stable');
INSERT INTO layout_items (ratio, owner, count, weight, region) VALUES (21.07, 'latest', 17, 4.51, 'primary');
INSERT INTO layout_items (ratio, owner, count, weight, region) VALUES (21.44, 'local', 67, 43.38, 'legacy');
