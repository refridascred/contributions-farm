-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, level, weight, ratio) VALUES (98, 59, 78.13, 17.67);
INSERT INTO layout_items (count, level, weight, ratio) VALUES (2, 90, 44.38, 66.73);
