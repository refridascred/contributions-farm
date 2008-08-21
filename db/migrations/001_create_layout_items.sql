-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, level, weight, ratio) VALUES (22, 5, 58.68, 89.04);
INSERT INTO layout_items (rank, level, weight, ratio) VALUES (50, 45, 63.42, 14.16);
INSERT INTO layout_items (rank, level, weight, ratio) VALUES (71, 4, 44.41, 53.31);
