-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (level, weight, count, ratio) VALUES (33, 73.05, 22, 65.22);
INSERT INTO layout_items (level, weight, count, ratio) VALUES (16, 95.32, 17, 23.0);
