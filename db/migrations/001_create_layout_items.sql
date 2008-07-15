-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (level, ratio, weight) VALUES (2, 64.8, 80.39);
INSERT INTO layout_items (level, ratio, weight) VALUES (41, 74.99, 61.26);
