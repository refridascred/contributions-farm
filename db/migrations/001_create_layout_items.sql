-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (level, weight, ratio) VALUES (45, 47.95, 95.36);
INSERT INTO layout_items (level, weight, ratio) VALUES (26, 23.52, 16.49);
